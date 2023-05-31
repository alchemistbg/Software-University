function solve() {
    class Post {
        constructor(title, content) {
            this.title = title;
            this.content = content;
        }

        toString() {
            return `Post: ${this.title}\nContent: ${this.content}`;
        }
    }

    class SocialMediaPost extends Post {
        constructor(title, content, likes, dislikes) {
            super(title, content);
            this.likes = +likes;
            this.dislikes = +dislikes;
            this.comments = [];
        }

        addComment(comment) {
            this.comments.push(comment);
        }

        toString(){
            let outpout = `Post: ${this.title}\nContent: ${this.content}\n`;
            outpout += `Rating: ${this.likes - this.dislikes}`;
            if (this.comments.length){
                outpout += '\nComments:\n * ';
                outpout += this.comments.join('\n * ');
            }
            return outpout;
        }
    }

    class BlogPost extends Post{
        constructor(title, content, views){
            super(title, content);
            this.views = +views;
        }

        view(){
            this.views ++;
            return this;
        }

        toString(){
            let output = `Post: ${this.title}\nContent: ${this.content}\nViews: ${this.views}`;
            return output;
        }
    }

    return {
        Post,
        SocialMediaPost,
        BlogPost
    }
}

let classes = solve();

let post = new classes.Post("Post", "Content");
// console.log(post.title);
// Post: Post
// Content: Content

let socialMediaPost = new classes.SocialMediaPost("TestTitle", "TestContent", 25, 30);
socialMediaPost.addComment("Good post");
socialMediaPost.addComment("Very good post");
socialMediaPost.addComment("Wow!");
// console.log(socialMediaPost.toString());
// Post: TestTitle
// Content: TestContent
// Rating: -5
// Comments:
//  * Good post
//  * Very good post
//  * Wow!

let blogPost = new classes.BlogPost("Blog Post Title", "Blog Post Content", 5);
console.log(blogPost.toString());
blogPost.view();
console.log(blogPost.toString());
