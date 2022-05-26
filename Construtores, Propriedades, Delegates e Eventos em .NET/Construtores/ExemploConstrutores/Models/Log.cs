namespace ExemploConstrutores.Models
{
    public class Log
    {
        private static Log _log;
        public string PropriedadeLog { get; set; }
        private Log() // evita que a classe seja instanciada diretamente
        {
            
        }

        public static Log GetInstance()
        {
            if(_log == null) // se _log for null a classe Log é instanciada
            {
                _log = new Log();
            }
            return _log; // se não for null só é retornado
        }
    }
}