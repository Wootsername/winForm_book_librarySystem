namespace winForm_book_librarySystem
{
    public static class Session
    {
        public static int CurrentUserId { get; set; }
        public static string CurrentUserRole { get; set; }
        public static string CurrentUserName { get; set; }
    }
}
