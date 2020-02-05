namespace ProAgil.WebAPI.Model
{
    public class Evento
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEnvento { get; set; }
        public string Tema { get; set; }
        public int QtdePessoas { get; set; }
        public string Lote { get; set; }
    }
}
