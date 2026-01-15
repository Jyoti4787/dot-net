using System.Collections.Generic;

namespace MiniSocialMedia
{
    // Interface that enforces posting behavior
    public interface IPostable
    {
        // Adds a new post
        void AddPost(string content);

        // Returns posts in read-only form
        IReadOnlyList<Post> GetPosts();
    }
}
