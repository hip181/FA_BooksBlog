using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "ntext", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "ntext", maxLength: 1024, nullable: true),
                    Count = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ShortDescription = table.Column<string>(type: "ntext", maxLength: 1024, nullable: true),
                    PostContent = table.Column<string>(type: "ntext", maxLength: 1024, nullable: true),
                    UrlSlug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Published = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    PostedOn = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ViewCount = table.Column<int>(type: "int", nullable: true),
                    RateCount = table.Column<int>(type: "int", nullable: true),
                    TotalRate = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostsCategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    CommentHeader = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CommentText = table.Column<string>(type: "ntext", nullable: true),
                    CommentTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTagMap",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTagMap", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTagMap_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTagMap_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { 1, "blog about Novel", "Novel", "blog-about-Novel" },
                    { 2, "blog about Cook", "Cook Book", "blog-about-Cook" },
                    { 3, "blog about detective ", "Detective", "blog-about-detective" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Count", "Description", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { 1, null, null, "Japanese Literature", null },
                    { 2, null, null, "Fiction", null },
                    { 3, null, null, "Childrens", null },
                    { 4, null, null, "Cook book", null }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Image", "Modified", "PostContent", "PostedOn", "Published", "RateCount", "ShortDescription", "Title", "TotalRate", "UrlSlug", "ViewCount" },
                values: new object[,]
                {
                    { 1, 1, "nw.jpg", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6871), "“I can describe the well in minute detail. It lay precisely on the border where the meadow ended and the woods began – a dark opening in the earth a yard across, hidden by grass. Nothing marked its perimeter – no fence, no stone curb (at least not one that rose above ground level). It was nothing but a hole, a wide-open mouth…You could lean over the edge and peer down to see nothing. All I knew about the well was its frightening depth. It was deep beyond measuring, and crammed full of darkness, as if all the world’s darknesses had been boiled down to their ultimate density.”", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6860), true, 0, "Toru, a quiet and preternaturally serious young college student in Tokyo, is devoted to Naoko, a beautiful and introspective young woman, but their mutual passion is marked by the tragic death of their best friend years before. Toru begins to adapt to campus life and the loneliness and isolation he faces there, but Naoko finds the pressures and responsibilities of life unbearable. As she retreats further into her own world, Toru finds himself reaching out to others and drawn to a fiercely independent and sexually liberated young woman.A magnificent blending of the music, the mood, and the ethos that was the sixties with the story of one college student's romantic coming of age, Norwegian Wood brilliantly recaptures a young man's first,hopeless,and heroic love.", "Norwegian Wood", 0, "Norwegian-Wood", 0 },
                    { 2, 1, "nlh.jpg", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6874), "I spent like three years just crazy depressed. Grim thoughts all the time, super self destructive, at once alienating and distributing \"cries for help\" or whatever you wanna call it... sheesh, man. It was so fucked. I'm really glad I got out of that frame of mind and I hope I never go back. No Longer Human was something I read toward the end of that phase. I probably would have been okay anyway, but this shit helped a ton. Dazai totally nails the impossibly bummed out mindset without being corny or melodramatic, and when you're basically just being a little sad black cloud all walking around, you're super cynical and things like this book are almost impossible to find 'cause your first reaction to everything is just to tear it apart and say it sucks... which is hella corny and melodramatic anyway, but if you know what it's like, like, being unbearably, unstoppably sad, and trying to put some sort of normal-ish face on it in your day to day life (between intermittent private and regrettable public freakouts probably), then well, this book pretty much covers all that really, really perfectly.", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6874), true, 0, "Osamu Dazai's No Longer Human, this leading postwar Japanese writer's second novel, tells the poignant and fascinating story of a young man who is caught between the breakup of the traditions of a northern Japanese aristocratic family and the impact of Western ideas. In consequence, he feels himself \"disqualified from being human\" (a literal translation of the Japanese title). Donald Keene, who translated this and Dazai's first novel, The Setting Sun, has said of the author's work: \"His world … suggests Chekhov or possibly postwar France, … but there is a Japanese sensibility in the choice and presentation of the material. A Dazai novel is at once immediately intelligible in Western terms and quite unlike any Western book.\"His writing is in some ways reminiscent of Rimbaud, while he himself has often been called a forerunner of Yukio Mishima. Cover painting by Noe Nojechowiz, from the collection of John and Barbara Duncan; design by Gertrude Huston", "No Longer Human", 0, "No-Longer-Human", 0 },
                    { 3, 2, "cic.jpg", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6876), "COCKTAILS IN COLOR celebrates the craft of drinkmaking, from raw ingredients to finished, delightful refreshments. Together, Sammi Katz and Olivia McGiff explore the elements, tastes, and techniques of all things drinks to create an accessible, visually delicious new guide to drinking that gives you the tools to design your own cocktails. Whether you’re a seasoned pro or new kid at the bar, COCKTAILS IN COLOR deserves a spot on your bar cart. Each page is fully illustrated with rich inspiring gouache paintings. This book encourages readers to explore a palette of ingredients for their developing palate.", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6876), true, 0, "An artistic cocktail book that is as beautiful as it is practical. By utilizing design and their expertise, Sammi and Olivia have created a vibrant, knowledgeable guide for both seasoned and newbie drinkmakers.  ", "Cocktails in Color", 0, "Cocktails-in-Color", 0 },
                    { 4, 1, "tlp.jpg", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6881), "In a grimy underground locked public toilet The Little Prince wakes slowly, he’s been out cold for hours. He’s bleeding from a gash on his upper arm. He finds he is chained by leg irons to the wall. There is another person sharing his predicament. It’s a bear, also chained to the opposite wall. In the center of the floor is the corpse of what appears to be donkey in a pool of blood. Near the corpse are a gun, a tape recorder and a saw“Grownups are very strange,” said the Little Prince to himself,sadly.", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6880), true, 0, "A pilot stranded in the desert awakes one morning to see, standing before him, the most extraordinary little fellow. \"Please,\"asks the stranger\",\"draw me a sheep.", "The little prince ", 0, "the-little-prince", 0 },
                    { 5, 3, "naoko.jpg", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6883), "I love Higashino's writing. With that said, this book I found disturbing. The premise is that Heisuke Sugita, a loving husband and father whose world rotates around family, turns on the television to hear of a horrible bus accident, a bus that his beloved family was on. His wife died protecting her daughter. The daughter lies sleeping in a deep coma. When Monami, his daughter, awakens the spirit and mind of the mother, Naoko, resides in her daughter's body. I can't go into too much detail concerning the plot as it would be a spoiler!Higashino's writing is the most plot driven I've read. Suffice it to say that the tale of this Japanese family becomes stranger and stranger. Heisuke believes his wife lives on in his daughter. Monami cooks for her father/ husband.All of his favorite dishes are prepared just as Naoko did.She has long conversation with him as he refers to her by the wife's name. In many ways it's as if he has lost neither his wife or daughter. Heisuke becomes more and more obsessed with his daughter's personal life, her friends and her plans for the future. At one point Monami speaking through her daughter's mouth bemoans the situation of Japanese women.", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6882), true, 0, "Naoko, a major bestseller and film in Japan, is a poignant and wily take on gender relations from a master of the detective story. ", "Naoko ", 0, "naoko", 0 },
                    { 6, 1, "tkm.jpg", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6884), "Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature.", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6884), true, 1, "The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it. To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.", "To Kill a Mockingbird", 4, "To-kill-a-mockingbird", 2 },
                    { 7, 1, "raj.jpg", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6887), "In this death-filled setting, the movement from love at first sight to the lovers’ final union in death seems almost inevitable. And yet, this play set in an extraordinary world has become the quintessential story of young love. In part because of its exquisite language, it is easy to respond as if it were about all young lovers.", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6886), true, 1, "In Romeo and Juliet, Shakespeare creates a violent world, in which two young people fall in love. It is not simply that their families disapprove; the Montagues and the Capulets are engaged in a blood feud.", "Romeo and Juliet", 4, "Romeo-and-Juliet", 2 },
                    { 8, 2, "ch.jpg", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6889), "The Mediterranean and DASH (Dietary Approaches to Stop Hypertension) eating patterns are scientifically proven to be the healthiest for our hearts, and they even have added brain health benefits. Combined, they make the MIND (Mediterranean-DASH Intervention for Neurodegenerative Delay) diet, which further reduces the risk of dementia and Alzheimer's disease. Cooking à la Heart incorporates all three into one nourishing, wholesome, environmentally friendly cookbook with With Cooking à la Heart, eating healthier isn't difficult or boring-it's an investment to keep you enjoying good food for many years to come.", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6888), true, 1, "Promote heart health, support brain health, and reduce inflammation, with this comprehensive cookbook filled with 500 flexible, flavorful recipes and practical tips for healthy eating.", "Cooking à la Heart", 4, "Cooking-a-lao-Heart", 2 },
                    { 9, 2, "hnd.jpg", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6891), "But HOW NOT TO DIET goes beyond food to identify twenty-one weight-loss accelerators available to our bodies, incorporating the latest discoveries in cutting-edge areas like chronobiology to reveal the factors that maximize our natural fat-burning capabilities. Dr. Greger builds the ultimate weight loss guide from the ground up, taking a timeless, proactive approach that can stand up to any new trend.", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6890), true, 1, "Dr. Greger hones in on the optimal criteria to enable weight loss, while considering how these foods actually affect our health and longevity. He lays out the key ingredients of the ideal weight-loss diet—factors such as calorie density, the insulin index, and the impact of foods on our gut microbiome—showing how plant-based eating is crucial to our success.", "How Not to Diet", 4, "How-Not-to-Diet", 2 },
                    { 10, 2, "iccv.jpg", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6893), "The book includes shopping lists, achievable goals, cheerleading, and an extensive FAQ, all written in Isa’s inimitable voice and style. But the book isn’t only for meat eaters looking for a better way to live: Isa wants to get vegans to start cooking more so that they can worry less about what they can and cannot eat. The perfect book for Isa’s legions of fans and anyone interested in learning vegan basics.", new DateTime(2023, 3, 8, 20, 33, 32, 975, DateTimeKind.Local).AddTicks(6892), true, 1, "Isa Chandra Moskowitz is the undisputed queen of vegan home cooking. Her readers turn to her for recipes that work, whether they’re looking for cupcakes that adhere to their diet or comforting Thanksgiving dinners that taste as satisfying as their childhood memories. With I Can Cook Vegan, Isa offers doable recipes designed to help inspire people to kick their meat habits, improve digestion, and become all-around better citizens of the world.", "I Can Cook Vegan", 4, "I-Can-Cook-Vegan", 2 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMap",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 4 },
                    { 4, 3 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 4 },
                    { 9, 4 },
                    { 10, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTagMap_TagId",
                table: "PostTagMap",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "PostTagMap");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
