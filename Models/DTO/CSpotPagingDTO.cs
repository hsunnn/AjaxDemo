namespace AjaxDemo.Models.DTO
{
    public class CSpotPagingDTO
    {
        public int TotalPages {  get; set; }
        public int TotalCount { get; set; }

        public List<SpotImagesSpot>? SpotResult { get; set; }
    }
}
