using ServicioConexión.Conexion;
using Supabase.Realtime;
using Supabase.Realtime.PostgresChanges;
using static Supabase.Realtime.PostgresChanges.PostgresChangesOptions;
using CapaDatos.Modelados.Productos;

namespace CapaServicios
{
    public static class GestorRealtime
    {
        private static Supabase.Client? _client;
        private static RealtimeChannel? _productosChannel;

        private static bool _iniciado = false;
        private static readonly SemaphoreSlim _lock = new SemaphoreSlim(1, 1);

        public static event Action<PostgresChangesResponse>? OnProductosChanged;

        public static bool EstaIniciado => _iniciado;

        public static async Task IniciarAsync()
        {
            if (_iniciado) return;

            await _lock.WaitAsync();
            try
            {
                if (_iniciado) return;

                _client = await ConexionSupabase.GetClientAsync();

                if (_client == null)
                    throw new Exception("No se pudo crear el cliente de Supabase.");

                _productosChannel = await _client.From<Productos>().On(ListenType.All, (sender, change) =>
                {
                    try { OnProductosChanged?.Invoke(change); } catch { }
                });

                _iniciado = true;

                System.Diagnostics.Debug.WriteLine("GestorRealtime iniciado correctamente.");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al iniciar GestorRealtime: {ex.Message}");
                throw;
            }
            finally
            {
                _lock.Release();
            }
        }

        public static async Task DetenerAsync()
        {
            if (!_iniciado) return;

            try
            {
                if (_productosChannel != null)
                {
                    _productosChannel.Unsubscribe();
                    _productosChannel = null;
                }

                _iniciado = false;
                System.Diagnostics.Debug.WriteLine("GestorRealtime detenido correctamente.");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al detener GestorRealtime: {ex.Message}");
            }
        }
    }
}