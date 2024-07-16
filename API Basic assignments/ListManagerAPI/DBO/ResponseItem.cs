namespace ListAPI.DBO
{
    public class ResponseItem : BaseResponse
    {
        public int Id {  get; set; }    
        public string Name { get; set; }
        public int Price {  get; set; }
    }
}
