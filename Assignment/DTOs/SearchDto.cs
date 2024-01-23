namespace Assignment.DTOs
{
    public class SearchDto
    {
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public string SortField { get; set; }
        public string SortOrder { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}
