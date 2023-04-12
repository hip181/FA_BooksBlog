using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.Models
{
    public static class JustBlogInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Novel",
                    Description = "blog about Novel",
                    UrlSlug = "blog-about-Novel"
                }, new Category()
                {
                    Id = 2,
                    Name = "Cook Book",
                    Description = "blog about Cook",
                    UrlSlug = "blog-about-Cook"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Detective",
                    Description = "blog about detective ",
                    UrlSlug = "blog-about-detective"
                }
            );
            modelBuilder.Entity<Post>().HasData(
                 new Post()
                 {
                     Id = 1,
                     Title = "Norwegian Wood",
                     ShortDescription = "Toru, a quiet and preternaturally serious young college student in Tokyo, is devoted to Naoko, a beautiful and introspective young woman, but their mutual passion is marked by the tragic death of their best friend years before. Toru begins to adapt to campus life and the loneliness and isolation he faces there, but Naoko finds the pressures and responsibilities of life unbearable. As she retreats further into her own world, Toru finds himself reaching out to others and drawn to a fiercely independent and sexually liberated young woman.A magnificent blending of the music, the mood, and the ethos that was the sixties with the story of one college student's romantic coming of age, Norwegian Wood brilliantly recaptures a young man's first,hopeless,and heroic love.",
                     PostContent = "“I can describe the well in minute detail. It lay precisely on the border where the meadow ended and the woods began – a dark opening in the earth a yard across, hidden by grass. Nothing marked its perimeter – no fence, no stone curb (at least not one that rose above ground level). It was nothing but a hole, a wide-open mouth…You could lean over the edge and peer down to see nothing. All I knew about the well was its frightening depth. It was deep beyond measuring, and crammed full of darkness, as if all the world’s darknesses had been boiled down to their ultimate density.”",
                     Published = true,
                     UrlSlug = "Norwegian-Wood",
                     PostedOn = DateTime.Now,
                     Modified = DateTime.Now,
                     CategoryId = 1,
                     Image = "nw.jpg"
                 },
                new Post()
                {
                    Id = 2,
                    Title = "No Longer Human",
                    ShortDescription = @"Osamu Dazai's No Longer Human, this leading postwar Japanese writer's second novel, tells the poignant and fascinating story of a young man who is caught between the breakup of the traditions of a northern Japanese aristocratic family and the impact of Western ideas. In consequence, he feels himself ""disqualified from being human"" (a literal translation of the Japanese title). Donald Keene, who translated this and Dazai's first novel, The Setting Sun, has said of the author's work: ""His world … suggests Chekhov or possibly postwar France, … but there is a Japanese sensibility in the choice and presentation of the material. A Dazai novel is at once immediately intelligible in Western terms and quite unlike any Western book.""His writing is in some ways reminiscent of Rimbaud, while he himself has often been called a forerunner of Yukio Mishima. Cover painting by Noe Nojechowiz, from the collection of John and Barbara Duncan; design by Gertrude Huston",
                    PostContent = @"I spent like three years just crazy depressed. Grim thoughts all the time, super self destructive, at once alienating and distributing ""cries for help"" or whatever you wanna call it... sheesh, man. It was so fucked. I'm really glad I got out of that frame of mind and I hope I never go back. No Longer Human was something I read toward the end of that phase. I probably would have been okay anyway, but this shit helped a ton. Dazai totally nails the impossibly bummed out mindset without being corny or melodramatic, and when you're basically just being a little sad black cloud all walking around, you're super cynical and things like this book are almost impossible to find 'cause your first reaction to everything is just to tear it apart and say it sucks... which is hella corny and melodramatic anyway, but if you know what it's like, like, being unbearably, unstoppably sad, and trying to put some sort of normal-ish face on it in your day to day life (between intermittent private and regrettable public freakouts probably), then well, this book pretty much covers all that really, really perfectly.",
                    Published = true,
                    UrlSlug = "No-Longer-Human",
                    PostedOn = DateTime.Now,
                    Modified = DateTime.Now,
                    CategoryId = 1,
                    Image = "nlh.jpg"
                },
                new Post()
                {
                    Id = 3,
                    Title = "Cocktails in Color",
                    ShortDescription = "An artistic cocktail book that is as beautiful as it is practical. By utilizing design and their expertise, Sammi and Olivia have created a vibrant, knowledgeable guide for both seasoned and newbie drinkmakers.  ",
                    PostContent = "COCKTAILS IN COLOR celebrates the craft of drinkmaking, from raw ingredients to finished, delightful refreshments. Together, Sammi Katz and Olivia McGiff explore the elements, tastes, and techniques of all things drinks to create an accessible, visually delicious new guide to drinking that gives you the tools to design your own cocktails. Whether you’re a seasoned pro or new kid at the bar, COCKTAILS IN COLOR deserves a spot on your bar cart. Each page is fully illustrated with rich inspiring gouache paintings. This book encourages readers to explore a palette of ingredients for their developing palate.",
                    Published = true,
                    UrlSlug = "Cocktails-in-Color",
                    PostedOn = DateTime.Now,
                    Modified = DateTime.Now,
                    CategoryId = 2,
                    Image = "cic.jpg"
                },
                new Post()
                {
                    Id = 4,
                    Title = "The little prince ",
                    ShortDescription = @"A pilot stranded in the desert awakes one morning to see, standing before him, the most extraordinary little fellow. ""Please,""asks the stranger"",""draw me a sheep.",
                    PostContent = @"In a grimy underground locked public toilet The Little Prince wakes slowly, he’s been out cold for hours. He’s bleeding from a gash on his upper arm. He finds he is chained by leg irons to the wall. There is another person sharing his predicament. It’s a bear, also chained to the opposite wall. In the center of the floor is the corpse of what appears to be donkey in a pool of blood. Near the corpse are a gun, a tape recorder and a saw“Grownups are very strange,” said the Little Prince to himself,sadly.",
                    Published = true,
                    UrlSlug = "the-little-prince",
                    PostedOn = DateTime.Now,
                    Modified = DateTime.Now,
                    CategoryId = 1,
                    Image = "tlp.jpg"

                },
                    new Post()
                    {
                        Id = 5,
                        Title = "Naoko ",
                        ShortDescription = "Naoko, a major bestseller and film in Japan, is a poignant and wily take on gender relations from a master of the detective story. ",
                        PostContent = @"I love Higashino's writing. With that said, this book I found disturbing. The premise is that Heisuke Sugita, a loving husband and father whose world rotates around family, turns on the television to hear of a horrible bus accident, a bus that his beloved family was on. His wife died protecting her daughter. The daughter lies sleeping in a deep coma. When Monami, his daughter, awakens the spirit and mind of the mother, Naoko, resides in her daughter's body. I can't go into too much detail concerning the plot as it would be a spoiler!Higashino's writing is the most plot driven I've read. Suffice it to say that the tale of this Japanese family becomes stranger and stranger. Heisuke believes his wife lives on in his daughter. Monami cooks for her father/ husband.All of his favorite dishes are prepared just as Naoko did.She has long conversation with him as he refers to her by the wife's name. In many ways it's as if he has lost neither his wife or daughter. Heisuke becomes more and more obsessed with his daughter's personal life, her friends and her plans for the future. At one point Monami speaking through her daughter's mouth bemoans the situation of Japanese women.",
                        Published = true,
                        UrlSlug = "naoko",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 3,
                        Image = "naoko.jpg"
                    },
                    new Post()
                    {
                        Id = 6,
                        Title = "To Kill a Mockingbird",
                        ShortDescription = "The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it. To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.",
                        UrlSlug = "To-kill-a-mockingbird",
                        Published = true,
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "tkm.jpg",
                        ViewCount = 2,
                        RateCount = 1,
                        TotalRate = 4,
                        PostContent = @"Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                new Post()
                {
                    Id = 7,
                    Title = "Romeo and Juliet",
                    ShortDescription = "In Romeo and Juliet, Shakespeare creates a violent world, in which two young people fall in love. It is not simply that their families disapprove; the Montagues and the Capulets are engaged in a blood feud.",
                    UrlSlug = "Romeo-and-Juliet",
                    Published = true,
                    PostedOn = DateTime.Now,
                    Modified = DateTime.Now,
                    CategoryId = 1,
                    Image = "raj.jpg",
                    ViewCount = 2,
                    RateCount = 1,
                    TotalRate = 4,
                    PostContent = "In this death-filled setting, the movement from love at first sight to the lovers’ final union in death seems almost inevitable. And yet, this play set in an extraordinary world has become the quintessential story of young love. In part because of its exquisite language, it is easy to respond as if it were about all young lovers."
                },
                new Post()
                {
                    Id = 8,
                    Title = "Cooking à la Heart",
                    ShortDescription = "Promote heart health, support brain health, and reduce inflammation, with this comprehensive cookbook filled with 500 flexible, flavorful recipes and practical tips for healthy eating.",
                    UrlSlug = "Cooking-a-lao-Heart",
                    Published = true,
                    PostedOn = DateTime.Now,
                    Modified = DateTime.Now,
                    CategoryId = 2,
                    Image = "ch.jpg",
                    ViewCount = 2,
                    RateCount = 1,
                    TotalRate = 4,
                    PostContent = "The Mediterranean and DASH (Dietary Approaches to Stop Hypertension) eating patterns are scientifically proven to be the healthiest for our hearts, and they even have added brain health benefits. Combined, they make the MIND (Mediterranean-DASH Intervention for Neurodegenerative Delay) diet, which further reduces the risk of dementia and Alzheimer's disease. Cooking à la Heart incorporates all three into one nourishing, wholesome, environmentally friendly cookbook with With Cooking à la Heart, eating healthier isn't difficult or boring-it's an investment to keep you enjoying good food for many years to come."
                },
                new Post()
                {
                    Id = 9,
                    Title = "How Not to Diet",
                    ShortDescription = "Dr. Greger hones in on the optimal criteria to enable weight loss, while considering how these foods actually affect our health and longevity. He lays out the key ingredients of the ideal weight-loss diet—factors such as calorie density, the insulin index, and the impact of foods on our gut microbiome—showing how plant-based eating is crucial to our success.",
                    UrlSlug = "How-Not-to-Diet",
                    Published = true,
                    PostedOn = DateTime.Now,
                    Modified = DateTime.Now,
                    CategoryId = 2,
                    Image = "hnd.jpg",
                    ViewCount = 2,
                    RateCount = 1,
                    TotalRate = 4,
                    PostContent = "But HOW NOT TO DIET goes beyond food to identify twenty-one weight-loss accelerators available to our bodies, incorporating the latest discoveries in cutting-edge areas like chronobiology to reveal the factors that maximize our natural fat-burning capabilities. Dr. Greger builds the ultimate weight loss guide from the ground up, taking a timeless, proactive approach that can stand up to any new trend."
                },
                new Post()
                {
                    Id = 10,
                    Title = "I Can Cook Vegan",
                    ShortDescription = "Isa Chandra Moskowitz is the undisputed queen of vegan home cooking. Her readers turn to her for recipes that work, whether they’re looking for cupcakes that adhere to their diet or comforting Thanksgiving dinners that taste as satisfying as their childhood memories. With I Can Cook Vegan, Isa offers doable recipes designed to help inspire people to kick their meat habits, improve digestion, and become all-around better citizens of the world.",
                    UrlSlug = "I-Can-Cook-Vegan",
                    Published = true,
                    PostedOn = DateTime.Now,
                    Modified = DateTime.Now,
                    CategoryId = 2,
                    Image = "iccv.jpg",
                    ViewCount = 2,
                    RateCount = 1,
                    TotalRate = 4,
                    PostContent = "The book includes shopping lists, achievable goals, cheerleading, and an extensive FAQ, all written in Isa’s inimitable voice and style. But the book isn’t only for meat eaters looking for a better way to live: Isa wants to get vegans to start cooking more so that they can worry less about what they can and cannot eat. The perfect book for Isa’s legions of fans and anyone interested in learning vegan basics."
                }

                );
            modelBuilder.Entity<Tag>().HasData(
                    new Tag() { Id = 1, Name = "Japanese Literature" },
                    new Tag() { Id = 2, Name = "Fiction" },
                    new Tag() { Id = 3, Name = "Childrens" },
                    new Tag() { Id = 4, Name = "Cook book" });
            modelBuilder.Entity<PostTagMap>().HasData(
               new PostTagMap() { PostId = 1, TagId = 1 },
                new PostTagMap() { PostId = 2, TagId = 1 },
                new PostTagMap() { PostId = 3, TagId = 4 },
                new PostTagMap() { PostId = 4, TagId = 3 },
                new PostTagMap() { PostId = 5, TagId = 2 },
                new PostTagMap() { PostId = 6, TagId = 2 },
                new PostTagMap() { PostId = 7, TagId = 2 },
                new PostTagMap() { PostId = 8, TagId = 4 },
                new PostTagMap() { PostId = 9, TagId = 4 },
                new PostTagMap() { PostId = 10, TagId = 4 });
        }
    }
}