namespace TaskManagementLib
{
    public class TaskModel
    {
        public int Id { get; set; }
        
        //Added data behaviour/attributes when no title is added
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        public string Description { get; set; }
        // Will add more properties after this check-in
    }
}
