using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Anthera.API.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "children",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false),
                    children_type = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_children", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "drinking",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false),
                    drinking_type = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drinking", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "education_level",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false),
                    education_level_name = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_education_level", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "eye_colour",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false),
                    colour = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eye_colour", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gender",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false),
                    gender_name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gender", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hair_colour",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false),
                    colour = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hair_colour", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "here_to",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false),
                    here_to_type = table.Column<string>(type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_here_to", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "interests",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    interest_type = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_interests", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "job_title",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job_title", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "language",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    language_name = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_language", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "personality",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    personality_name = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personality", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "photo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    photo_url = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "preference_sex",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false),
                    sex = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_preference_sex", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "relationship",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false),
                    relationship_type = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relationship", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "religion",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    religion_name = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_religion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false),
                    role_name = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sexuality",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false),
                    sexuality_type = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sexuality", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "smoking",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false),
                    smoking_type = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_smoking", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "preference",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    age_min = table.Column<byte>(nullable: false),
                    age_max = table.Column<byte>(nullable: false),
                    distance = table.Column<byte>(nullable: false),
                    preference_sex_id = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_preference", x => x.id);
                    table.ForeignKey(
                        name: "FKpreference611362",
                        column: x => x.preference_sex_id,
                        principalTable: "preference_sex",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(14)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    email_address = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    password = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    profile_picture_url = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    last_online = table.Column<DateTime>(type: "timestamp", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    is_info_completed = table.Column<bool>(nullable: false),
                    is_deactivated = table.Column<bool>(nullable: false),
                    role_id = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                    table.ForeignKey(
                        name: "FKuser994439",
                        column: x => x.role_id,
                        principalTable: "role",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "refresh_token",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    refresh_token_value = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    is_invalidated = table.Column<bool>(nullable: false),
                    issued_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    user_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refresh_token", x => x.id);
                    table.ForeignKey(
                        name: "FKrefresh_to567261",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user_info",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<int>(nullable: false),
                    gender_id = table.Column<byte>(nullable: false),
                    preference_id = table.Column<int>(nullable: false),
                    dob = table.Column<DateTime>(type: "datetime", nullable: false),
                    city = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    ip_address = table.Column<string>(type: "varchar(150)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    job_title_id = table.Column<int>(nullable: false),
                    company_name = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    school_university = table.Column<string>(type: "varchar(250)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    about_me = table.Column<string>(type: "varchar(500)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    relationship_id = table.Column<byte>(nullable: false),
                    sexuality_id = table.Column<byte>(nullable: false),
                    height = table.Column<string>(type: "varchar(40)", nullable: false, defaultValueSql: "'I''d prefer not to say'")
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    weight = table.Column<string>(type: "varchar(40)", nullable: false, defaultValueSql: "'I''d prefer not to say'")
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    eye_colour_id = table.Column<byte>(nullable: false),
                    hair_colour_id = table.Column<byte>(nullable: false),
                    children_id = table.Column<byte>(nullable: false),
                    smoking_id = table.Column<byte>(nullable: false),
                    drinking_id = table.Column<byte>(nullable: false),
                    here_to_id = table.Column<byte>(nullable: false),
                    photo_limit = table.Column<byte>(nullable: false, defaultValueSql: "'6'"),
                    religion_id = table.Column<int>(nullable: false),
                    education_level_id = table.Column<byte>(nullable: false),
                    personality_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_info", x => x.id);
                    table.ForeignKey(
                        name: "FKuser_info865355",
                        column: x => x.children_id,
                        principalTable: "children",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info390466",
                        column: x => x.drinking_id,
                        principalTable: "drinking",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info490875",
                        column: x => x.education_level_id,
                        principalTable: "education_level",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info751412",
                        column: x => x.eye_colour_id,
                        principalTable: "eye_colour",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info498432",
                        column: x => x.gender_id,
                        principalTable: "gender",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info890322",
                        column: x => x.hair_colour_id,
                        principalTable: "hair_colour",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info830718",
                        column: x => x.here_to_id,
                        principalTable: "here_to",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info963064",
                        column: x => x.job_title_id,
                        principalTable: "job_title",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info129223",
                        column: x => x.personality_id,
                        principalTable: "personality",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info558053",
                        column: x => x.preference_id,
                        principalTable: "preference",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info718147",
                        column: x => x.relationship_id,
                        principalTable: "relationship",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info800964",
                        column: x => x.religion_id,
                        principalTable: "religion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info840976",
                        column: x => x.sexuality_id,
                        principalTable: "sexuality",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info916383",
                        column: x => x.smoking_id,
                        principalTable: "smoking",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info674202",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_info_interest",
                columns: table => new
                {
                    user_info_id = table.Column<int>(nullable: false),
                    interests_id = table.Column<int>(nullable: false),
                    user_infouser_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.user_info_id, x.interests_id, x.user_infouser_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                    table.ForeignKey(
                        name: "FKuser_info_434712",
                        column: x => x.interests_id,
                        principalTable: "interests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info_156893",
                        column: x => x.user_info_id,
                        principalTable: "user_info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user_info_language",
                columns: table => new
                {
                    language_id = table.Column<int>(nullable: false),
                    user_info_id = table.Column<int>(nullable: false),
                    user_infouser_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.language_id, x.user_info_id, x.user_infouser_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                    table.ForeignKey(
                        name: "FKuser_info_393481",
                        column: x => x.language_id,
                        principalTable: "language",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info_837564",
                        column: x => x.user_info_id,
                        principalTable: "user_info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user_info_photo",
                columns: table => new
                {
                    photo_id = table.Column<int>(nullable: false),
                    user_info_id = table.Column<int>(nullable: false),
                    user_infouser_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.photo_id, x.user_info_id, x.user_infouser_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                    table.ForeignKey(
                        name: "FKuser_info_956427",
                        column: x => x.photo_id,
                        principalTable: "photo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKuser_info_972894",
                        column: x => x.user_info_id,
                        principalTable: "user_info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "children",
                columns: new[] { "id", "children_type" },
                values: new object[,]
                {
                    { (byte)1, "Grown up" },
                    { (byte)2, "Already have" },
                    { (byte)3, "No, never" },
                    { (byte)4, "Someday" },
                    { (byte)5, "I'd perfer not to say" }
                });

            migrationBuilder.InsertData(
                table: "drinking",
                columns: new[] { "id", "drinking_type" },
                values: new object[,]
                {
                    { (byte)1, "I drink socialy" },
                    { (byte)2, "Never" },
                    { (byte)3, "I drink often" },
                    { (byte)4, "No, I'm sober" },
                    { (byte)5, "I'd perfer not to say" }
                });

            migrationBuilder.InsertData(
                table: "education_level",
                columns: new[] { "id", "education_level_name" },
                values: new object[,]
                {
                    { (byte)6, "I'd perfer not to say" },
                    { (byte)4, "Diploma" },
                    { (byte)5, "High school" },
                    { (byte)2, "Masters" },
                    { (byte)1, "Doctors" },
                    { (byte)3, "Bachelors" }
                });

            migrationBuilder.InsertData(
                table: "eye_colour",
                columns: new[] { "id", "colour" },
                values: new object[,]
                {
                    { (byte)7, "I'd perfer not to say" },
                    { (byte)5, "Amber" },
                    { (byte)4, "Hazel" },
                    { (byte)6, "Cosmetic Iris" },
                    { (byte)2, "Brown" },
                    { (byte)1, "Blue" },
                    { (byte)3, "Green" }
                });

            migrationBuilder.InsertData(
                table: "gender",
                columns: new[] { "id", "gender_name" },
                values: new object[,]
                {
                    { (byte)1, "Female" },
                    { (byte)2, "Male" },
                    { (byte)3, "TransWoman" },
                    { (byte)4, "TransMan" }
                });

            migrationBuilder.InsertData(
                table: "hair_colour",
                columns: new[] { "id", "colour" },
                values: new object[,]
                {
                    { (byte)7, "Bald" },
                    { (byte)8, "I'd perfer not to say" },
                    { (byte)6, "Shaved" },
                    { (byte)5, "Dyed" },
                    { (byte)3, "Blonde" },
                    { (byte)2, "Brown" },
                    { (byte)1, "Black" },
                    { (byte)4, "Red" }
                });

            migrationBuilder.InsertData(
                table: "here_to",
                columns: new[] { "id", "here_to_type" },
                values: new object[,]
                {
                    { (byte)1, "I'm here to chat" },
                    { (byte)2, "I'm Here to date" },
                    { (byte)3, "I'm here for a relationship" }
                });

            migrationBuilder.InsertData(
                table: "job_title",
                columns: new[] { "id", "title" },
                values: new object[,]
                {
                    { 571, "Natural Sciences Manager" },
                    { 580, "Nursing Instructor" },
                    { 579, "Nursing Aide" },
                    { 578, "Nuclear Technician" },
                    { 577, "Nuclear Power Reactor Operator" },
                    { 574, "Nonfarm Animal Caretaker" },
                    { 575, "Nuclear Engineer" },
                    { 581, "Teacher" },
                    { 573, "New Accounts Clerk" },
                    { 572, "Network and Computer Systems Administrator" },
                    { 576, "Nuclear Medicine Technologist" },
                    { 582, "Obstetrician" },
                    { 586, "Occupational Therapist" },
                    { 584, "Occupational Health and Safety Specialist" },
                    { 585, "Occupational Health and Safety Technician" },
                    { 587, "Occupational Therapy Aide" },
                    { 588, "Occupational Therapy Assistant" },
                    { 589, "Office Clerk" },
                    { 590, "Office Machine Operator" },
                    { 591, "Office and Administrative Support Worker" },
                    { 592, "Operating Engineer" },
                    { 593, "Other Construction Equipment Operator" },
                    { 594, "Operations Research Analyst" },
                    { 583, "Gynecologist" },
                    { 570, "Singer" },
                    { 551, "Mixing and Blending Machine Setter" },
                    { 568, "Tuner" },
                    { 545, "Milling and Planing Machine Setter" },
                    { 546, "Millwright" },
                    { 547, "Mine Cutting and Channeling Machine Operator" },
                    { 548, "Mine Shuttle Car Operator" },
                    { 549, "Mining Machine Operator" },
                    { 550, "Mining and Geological Engineer" },
                    { 595, "Ophthalmic Laboratory Technician" },
                    { 552, "Mobile Heavy Equipment Mechanic" },
                    { 553, "Model Maker" },
                    { 554, "Molder" },
                    { 555, "Motion Picture Projectionist" },
                    { 556, "Motor Vehicle Operator" },
                    { 557, "Motorboat Mechanic" },
                    { 558, "Motorboat Operator" },
                    { 559, "Motorcycle Mechanic" },
                    { 560, "Multimedia Artist" },
                    { 561, "Animator" },
                    { 562, "Multiple Machine Tool Setter" },
                    { 563, "Museum Technician" },
                    { 564, "Conservator" },
                    { 565, "Music Director" },
                    { 566, "Composer" },
                    { 567, "Musical Instrument Repairer" },
                    { 569, "Musician" },
                    { 596, "Optician" },
                    { 615, "Parts Salesperson" },
                    { 598, "Oral and Maxillofacial Surgeon" },
                    { 626, "Petroleum Engineer" },
                    { 627, "Petroleum Pump System Operator" },
                    { 629, "Pharmacy Aide" },
                    { 630, "Pharmacy Technician" },
                    { 631, "Philosophy and Religion Teacher" },
                    { 632, "Photographer" },
                    { 633, "Photographic Process Worker" },
                    { 634, "Processing Machine Operator" },
                    { 635, "Physical Scientist" },
                    { 636, "Physical Therapist Aide" },
                    { 637, "Physical Therapist Assistant" },
                    { 638, "Physical Therapist" },
                    { 639, "Physician Assistant" },
                    { 640, "Physician" },
                    { 641, "Surgeon" },
                    { 642, "Physicist" },
                    { 643, "Physics Teacher" },
                    { 644, "Pile-Driver Operator" },
                    { 645, "Pipelayer" },
                    { 646, "Plant and System Operator" },
                    { 647, "Plasterer" },
                    { 648, "Stucco Mason" },
                    { 649, "Plating and Coating Machine Setter" },
                    { 625, "Pesticide Handler" },
                    { 597, "Optometrist" },
                    { 624, "Pest Control Worker" },
                    { 622, "Personal Care and Service Worker" },
                    { 599, "Order Clerk" },
                    { 600, "Orthodontist" },
                    { 601, "Orthotist" },
                    { 602, "Prosthetist" },
                    { 603, "Outdoor Power Equipment and Other Small Engine Mechanic" },
                    { 604, "Packaging and Filling Machine Operator" },
                    { 605, "Packer" },
                    { 606, "Packager" },
                    { 607, "Painter" },
                    { 608, "Painting" },
                    { 609, "Paper Goods Machine Setter" },
                    { 610, "Paperhanger" },
                    { 611, "Paralegal" },
                    { 612, "Legal Assistant" },
                    { 613, "Parking Enforcement Worker" },
                    { 614, "Parking Lot Attendant" },
                    { 544, "Middle School Teacher" },
                    { 616, "Patternmaker" },
                    { 617, "Paving" },
                    { 618, "Payroll and Timekeeping Clerk" },
                    { 619, "Pediatrician" },
                    { 620, "Personal Care Aide" },
                    { 621, "Personal Care and Service Occupation" },
                    { 623, "Personal Financial Advisor" },
                    { 543, "Microbiologist" },
                    { 524, "Medical Appliance Technician" },
                    { 541, "Metal-Refining Furnace Operator" },
                    { 463, "Legal Occupation" },
                    { 464, "Legal Secretary" },
                    { 465, "Legal Support Worker" },
                    { 466, "Legislator" },
                    { 467, "Librarian" },
                    { 468, "Library Assistant" },
                    { 469, "Library Science Teacher" },
                    { 470, "Library Technician" },
                    { 471, "Licensed Practical and Licensed Vocational Nurse" },
                    { 472, "Life Scientist" },
                    { 473, "Lifeguard" },
                    { 474, "Light Truck or Delivery Services Driver" },
                    { 475, "Loading Machine Operator" },
                    { 476, "Loan Interviewer" },
                    { 477, "Clerk" },
                    { 478, "Loan Officer" },
                    { 479, "Locksmith" },
                    { 480, "Safe Repairer" },
                    { 481, "Locomotive Engineer" },
                    { 482, "Locomotive Firer" },
                    { 483, "Lodging Manager" },
                    { 484, "Log Grader" },
                    { 485, "Scaler" },
                    { 462, "Layout Worker" },
                    { 486, "Logging Equipment Operator" },
                    { 461, "Lawyer" },
                    { 459, "Laundry and Dry-Cleaning Worker" },
                    { 436, "Inspector" },
                    { 437, "Instructional Coordinator" },
                    { 438, "Insulation Worker" },
                    { 439, "Insurance Appraiser" },
                    { 440, "Insurance Claim" },
                    { 441, "Policy Processing Clerk" },
                    { 442, "Insurance Sales Agent" },
                    { 443, "Insurance Underwriter" },
                    { 444, "Interior Designer" },
                    { 445, "Internist" },
                    { 446, "Interpreter" },
                    { 447, "Translator" },
                    { 448, "Interviewer" },
                    { 449, "Janitor" },
                    { 450, "Cleaner" },
                    { 451, "Jeweler" },
                    { 452, "Precious Stone and Metal Worker" },
                    { 453, "Judge" },
                    { 454, "Judicial Law Clerk" },
                    { 455, "Kindergarten Teacher" },
                    { 456, "Landscape Architect" },
                    { 457, "Landscaping and Groundskeeping Worker" },
                    { 458, "Lathe and Turning Machine Tool Setter" },
                    { 460, "Law Teacher" },
                    { 487, "Logging Worker" },
                    { 488, "Logisticians " },
                    { 489, "Machine Feeder" },
                    { 518, "Mechanical Door Repairer" },
                    { 519, "Mechanical Drafter" },
                    { 520, "Mechanical Engineering Technician" },
                    { 521, "Mechanical Engineer" },
                    { 522, "Media and Communication Equipment Worker" },
                    { 523, "Media and Communication Worker" },
                    { 650, "Plumber" },
                    { 525, "Medical Assistant" },
                    { 526, "Medical Equipment Preparer" },
                    { 527, "Medical Equipment Repairer" },
                    { 528, "Health Information Technician" },
                    { 529, "Medical Scientist" },
                    { 530, "Medical Secretary" },
                    { 531, "Medical Transcriptionist" },
                    { 532, "Medical and Clinical Laboratory Technician" },
                    { 533, "Medical and Clinical Laboratory Technologist" },
                    { 534, "Medical and Health Services Manager" },
                    { 535, "Mental Health Counselor" },
                    { 536, "Mental Health and Substance Abuse Social Worker" },
                    { 537, "Merchandise Displayer" },
                    { 538, "Window Trimmer" },
                    { 539, "Metal Worker" },
                    { 540, "Plastic Worker" },
                    { 517, "Mathematician" },
                    { 516, "Mathematical Technician" },
                    { 515, "Mathematical Science Teacher" },
                    { 514, "Mathematical Science Occupation" },
                    { 490, "Machinist" },
                    { 491, "Maid" },
                    { 492, "Housekeeping Cleaner" },
                    { 493, "Mail Clerk" },
                    { 494, "Mail Machine Operator" },
                    { 495, "Maintenance Worker" },
                    { 496, "Maintenance and Repair Worker" },
                    { 497, "Makeup Artist" },
                    { 498, "Management Analyst" },
                    { 499, "Management Occupation" },
                    { 500, "Manager" },
                    { 542, "Meter Reader" },
                    { 501, "Manicurist" },
                    { 503, "Manufactured Building and Mobile Home Installer" },
                    { 504, "Marine Engineer" },
                    { 505, "Naval Architect" },
                    { 506, "Market Research Analyst" },
                    { 507, "Marketing Specialist" },
                    { 508, "Marketing Manager" },
                    { 509, "Marriage and Family Therapist" },
                    { 510, "Massage Therapist" },
                    { 511, "Material Moving Worker" },
                    { 512, "Materials Engineer" },
                    { 513, "Materials Scientist" },
                    { 502, "Pedicurist" },
                    { 651, "Podiatrist" },
                    { 670, "Printing Press Operator" },
                    { 653, "Political Science Teacher" },
                    { 790, "Fitter" },
                    { 791, "Substance Abuse and Behavioral Disorder Counselor" },
                    { 792, "Subway and Streetcar Operator" },
                    { 793, "Surgical Technologist" },
                    { 794, "Survey Researcher" },
                    { 795, "Surveying and Mapping Technician" },
                    { 796, "Surveyor" },
                    { 797, "Switchboard Operator" },
                    { 798, "Tailor" },
                    { 799, "Tank Car" },
                    { 800, "Taper" },
                    { 801, "Tax Examiner" },
                    { 802, "Collector" },
                    { 803, "Tax Preparer" },
                    { 804, "Taxi Driver" },
                    { 805, "Chauffeur" },
                    { 806, "Teacher Assistant" },
                    { 807, "Team Assembler" },
                    { 808, "Technical Writer" },
                    { 809, "Telecommunications Equipment Installer" },
                    { 810, "Telecommunications Line Installer" },
                    { 811, "Telemarketer" },
                    { 812, "Telephone Operator" },
                    { 789, "Structural Metal Fabricator" },
                    { 813, "Teller" },
                    { 788, "Structural Iron and Steel Worker" },
                    { 786, "Order Filler" },
                    { 763, "Skincare Specialist" },
                    { 764, "Slaughterer" },
                    { 765, "Meat Packer" },
                    { 766, "Slot Supervisor" },
                    { 767, "Social Science Research Assistant" },
                    { 768, "Social Sciences Teacher" },
                    { 769, "Social Scientist" },
                    { 770, "Social Work Teacher" },
                    { 771, "Social Worker" },
                    { 772, "Social and Community Service Manager" },
                    { 773, "Social and Human Service Assistant" },
                    { 774, "Sociologist" },
                    { 775, "Sociology Teacher" },
                    { 776, "Software Developer" },
                    { 777, "Soil and Plant Scientist" },
                    { 778, "Sound Engineering Technician" },
                    { 779, "Special Education Teacher" },
                    { 780, "Speech-Language Pathologist" },
                    { 781, "Stationary Engineer" },
                    { 782, "Boiler Operator" },
                    { 783, "Statistical Assistant" },
                    { 784, "Statistician" },
                    { 785, "Stock Clerk" },
                    { 787, "Stonemason" },
                    { 814, "Terrazzo Worker" },
                    { 815, "Textile Bleaching and Dyeing Machine Operator" },
                    { 816, "Textile Cutting Machine Setter" },
                    { 845, "Usher" },
                    { 846, "Veterinarian" },
                    { 847, "Veterinary Assistant" },
                    { 848, "Laboratory Animal Caretaker" },
                    { 849, "Veterinary Technologist" },
                    { 850, "Vocational Education Teacher" },
                    { 851, "Waiter" },
                    { 852, "Waitress" },
                    { 853, "Watch Repairer" },
                    { 854, "Water and Wastewater Treatment Plant and System Operator" },
                    { 855, "Weigher" },
                    { 856, "Welder" },
                    { 857, "Welding" },
                    { 858, "Wellhead Pumper" },
                    { 859, "Wholesale and Retail Buyer" },
                    { 860, "Woodworker" },
                    { 861, "Woodworking Machine Setter" },
                    { 862, "Word Processor" },
                    { 863, "Typist" },
                    { 864, "Writer" },
                    { 865, "Authors " },
                    { 866, "Zoologist" },
                    { 867, "Wildlife Biologist" },
                    { 844, "Urban and Regional Planner" },
                    { 843, "Upholsterer" },
                    { 842, "Umpire" },
                    { 841, "Pruner" },
                    { 817, "Textile Knitting and Weaving Machine Setter" },
                    { 818, "Therapist" },
                    { 819, "Tile and Marble Setter" },
                    { 820, "Timing Device Assembler" },
                    { 821, "Adjuster" },
                    { 822, "Tire Builder" },
                    { 823, "Tire Repairer" },
                    { 824, "Changer" },
                    { 825, "Title Examiner" },
                    { 826, "Tool Grinder" },
                    { 827, "Tool and Die Maker" },
                    { 762, "Signal and Track Switch Repairer" },
                    { 828, "Tour Guide" },
                    { 830, "Traffic Technician" },
                    { 831, "Training and Development Manager" },
                    { 832, "Training and Development Specialist" },
                    { 833, "Transit and Railroad Police" },
                    { 834, "Transportation Attendant" },
                    { 835, "Transportation Inspector" },
                    { 836, "Transportation Security Screener" },
                    { 837, "Transportation Worker" },
                    { 838, "Travel Agent" },
                    { 839, "Travel Guide" },
                    { 840, "Tree Trimmer" },
                    { 829, "Escort" },
                    { 652, "Police and Sheriff's Patrol Officer" },
                    { 761, "Shoe and Leather Worker" },
                    { 759, "Shipping" },
                    { 681, "Property" },
                    { 682, "Prosthodontist" },
                    { 683, "Protective Service Occupation" },
                    { 684, "Protective Service Worker" },
                    { 685, "Psychiatric Aide" },
                    { 686, "Psychiatric Technician" },
                    { 687, "Psychiatrist" },
                    { 688, "Psychologist" },
                    { 689, "Psychology Teacher" },
                    { 690, "Public Address System and Other Announcer" },
                    { 691, "Public Relations Specialist" },
                    { 692, "Public Relation" },
                    { 693, "Fundraising Manager" },
                    { 694, "Pump Operator" },
                    { 695, "Purchasing Manager" },
                    { 696, "Radiation Therapist" },
                    { 697, "Radio Operator" },
                    { 698, "Radio and Television Announcer" },
                    { 699, "Radiologic Technologist" },
                    { 700, "Rail Car Repairer" },
                    { 701, "Rail Transportation Worker" },
                    { 702, "Rail Yard Engineer" },
                    { 703, "Rail-Track Laying and Maintenance Equipment Operator" },
                    { 680, "Copy Marker" },
                    { 704, "Railroad Brake" },
                    { 679, "Proofreader" },
                    { 677, "Production Worker" },
                    { 654, "Political Scientist" },
                    { 655, "Postal Service Clerk" },
                    { 656, "Postal Service Mail Carrier" },
                    { 657, "Postal Service Mail Sorter" },
                    { 658, "Postmaster" },
                    { 659, "Mail Superintendent" },
                    { 660, "Postsecondary Teacher" },
                    { 661, "Pourer" },
                    { 662, "Caster" },
                    { 663, "Power Distributor" },
                    { 664, "Power Plant Operator" },
                    { 665, "Precision Instrument and Equipment Repairer" },
                    { 666, "Prepress Technician" },
                    { 667, "Preschool Teacher" },
                    { 668, "Presser" },
                    { 669, "Print Binding and Finishing Worker" },
                    { 435, "Information and Record Clerk" },
                    { 671, "Private Detective" },
                    { 672, "Probation Officer" },
                    { 673, "Correctional Treatment Specialist" },
                    { 674, "Procurement Clerk" },
                    { 675, "Producer" },
                    { 676, "Production Occupation" },
                    { 678, "Production" },
                    { 705, "Railroad Conductor" },
                    { 706, "Yardmaster" },
                    { 707, "Real Estate Broker" },
                    { 736, "Sailor" },
                    { 737, "Marine Oiler" },
                    { 738, "Sales Engineer" },
                    { 739, "Sales Manager" },
                    { 740, "Sales Representative" },
                    { 741, "Sawing Machine Setter" },
                    { 742, "Secondary School Teacher" },
                    { 743, "Secretary" },
                    { 744, "Administrative Assistant" },
                    { 745, "Security Guard" },
                    { 746, "Security and Fire Alarm Systems Installer" },
                    { 747, "Segmental Paver" },
                    { 748, "Self-Enrichment Education Teacher" },
                    { 749, "Semiconductor Processor" },
                    { 750, "Septic Tank Servicer" },
                    { 751, "Sewer Pipe Cleaner" },
                    { 752, "Service Unit Operator" },
                    { 753, "Set and Exhibit Designer" },
                    { 754, "Sewer" },
                    { 755, "Sewing Machine Operator" },
                    { 756, "Shampooer" },
                    { 757, "Sheet Metal Worker" },
                    { 758, "Ship Engineer" },
                    { 735, "Roustabout" },
                    { 734, "Rotary Drill Operator" },
                    { 733, "Roofer" },
                    { 732, "Roof Bolter" },
                    { 708, "Real Estate Sales Agent" },
                    { 709, "Receptionist" },
                    { 710, "Information Clerk" },
                    { 711, "Recreation Worker" },
                    { 712, "Recreation and Fitness Studies Teacher" },
                    { 713, "Recreational Therapist" },
                    { 714, "Recreational Vehicle Service Technician" },
                    { 715, "Refractory Materials Repairer" },
                    { 716, "Refuse and Recyclable Material Collector" },
                    { 717, "Registered Nurse" },
                    { 718, "Rehabilitation Counselor" },
                    { 760, "Shoe Machine Operator" },
                    { 719, "Reinforcing Iron and Rebar Worker" },
                    { 721, "Reporter" },
                    { 722, "Correspondent" },
                    { 723, "Reservation and Transportation Ticket Agent" },
                    { 724, "Travel Clerk" },
                    { 725, "Residential Advisor" },
                    { 726, "Respiratory Therapist" },
                    { 727, "Respiratory Therapy Technician" },
                    { 728, "Retail Salesperson" },
                    { 729, "Rigger" },
                    { 730, "Rock Splitter" },
                    { 731, "Rolling Machine Setter" },
                    { 720, "Religious Worker" },
                    { 434, "Information Security Analyst" },
                    { 628, "Pharmacist" },
                    { 432, "Industrial Truck and Tractor Operator" },
                    { 137, "Childcare Worker" },
                    { 138, "Chiropractor" },
                    { 139, "Choreographer" },
                    { 140, "Civil Engineering Technician" },
                    { 141, "Civil Engineer" },
                    { 142, "Claims Adjuster" },
                    { 143, "Cleaners of Vehicle" },
                    { 144, "Equipment" },
                    { 145, "Cleaning" },
                    { 146, "Clergy" },
                    { 147, "Clinical" },
                    { 148, "Coache" },
                    { 149, "Scout" },
                    { 150, "Coating" },
                    { 151, "Coil Winder" },
                    { 152, "Coin" },
                    { 153, "Combined Food Preparation and Serving Worker" },
                    { 154, "Commercial Diver" },
                    { 155, "Commercial Pilot" },
                    { 156, "Commercial and Industrial Designer" },
                    { 157, "Communications Equipment Operator" },
                    { 158, "Communications Teacher" },
                    { 159, "Community and Social Service Specialist" },
                    { 136, "Child" },
                    { 160, "Community and Social Service Occupation" },
                    { 135, "Chief Executive" },
                    { 133, "Chemistry Teacher" },
                    { 110, "Purchasing Agent" },
                    { 111, "Cabinetmaker" },
                    { 112, "Bench Carpenter" },
                    { 113, "Camera Operator" },
                    { 114, "Camera and Photographic Equipment Repairer" },
                    { 115, "Captain" },
                    { 116, "Cardiovascular Technologist" },
                    { 117, "Technician" },
                    { 118, "Career/Technical Education Teacher" },
                    { 119, "Cargo and Freight Agent" },
                    { 120, "Carpenter" },
                    { 121, "Carpet Installer" },
                    { 122, "Cartographer" },
                    { 123, "Photogrammetrist" },
                    { 124, "Cashier" },
                    { 125, "Cement Mason" },
                    { 126, "Concrete Finisher" },
                    { 127, "Chef" },
                    { 128, "Head Cook" },
                    { 129, "Chemical Engineer" },
                    { 130, "Chemical Equipment Operator" },
                    { 131, "Chemical Plant and System Operator" },
                    { 132, "Chemical Technician" },
                    { 134, "Chemist" },
                    { 161, "Compensation and Benefits Manager" },
                    { 162, "Compensation" },
                    { 163, "Compliance Officer" },
                    { 192, "Cost Estimator" },
                    { 193, "Costume Attendant" },
                    { 194, "Counselor" },
                    { 195, "Counter Attendant" },
                    { 196, "Counter and Rental Clerk" },
                    { 197, "Courier" },
                    { 198, "Messenger" },
                    { 199, "Court Reporter" },
                    { 200, "Court" },
                    { 201, "Craft Artist" },
                    { 202, "Crane and Tower Operator" },
                    { 203, "Credit Analyst" },
                    { 204, "Credit Authorizer" },
                    { 205, "Credit Counselor" },
                    { 206, "Criminal Justice and Law Enforcement Teacher" },
                    { 207, "Crossing Guard" },
                    { 208, "Crushing" },
                    { 209, "Curator" },
                    { 210, "Customer Service Representative" },
                    { 211, "Cutter" },
                    { 212, "Trimmer" },
                    { 213, "Cutting and Slicing Machine Setter" },
                    { 214, "Cutting" },
                    { 191, "Correspondence Clerk" },
                    { 190, "Jailer" },
                    { 189, "Correctional Officer" },
                    { 188, "Cooling and Freezing Equipment Operator" },
                    { 164, "Computer Hardware Engineer" },
                    { 165, "Computer Numerically Controlled Machine Tool Programmer" },
                    { 166, "Computer Occupation" },
                    { 167, "Computer Operator" },
                    { 168, "Computer Programmer" },
                    { 169, "Computer Science Teacher" },
                    { 170, "Computer Support Specialist" },
                    { 171, "Computer Systems Analyst" },
                    { 172, "Computer and Information Research Scientist" },
                    { 173, "Computer and Information Systems Manager" },
                    { 174, "Computer and Mathematical Occupation" },
                    { 109, "Buyer" },
                    { 175, "Computer" },
                    { 177, "Concierge" },
                    { 178, "Conservation Scientist" },
                    { 179, "Construction Laborer" },
                    { 180, "Construction Manager" },
                    { 181, "Construction and Building Inspector" },
                    { 182, "Construction and Extraction Occupation" },
                    { 183, "Construction and Related Worker" },
                    { 184, "Continuous Mining Machine Operator" },
                    { 185, "Control and Valve Installer" },
                    { 186, "Conveyor Operator" },
                    { 187, "Cook" },
                    { 176, "Computer-Controlled Machine Tool Operator" },
                    { 215, "Dancer" },
                    { 108, "Meat Cutter" },
                    { 106, "Financial Operations Occupation" },
                    { 28, "Aircraft Structure" },
                    { 29, "Airfield Operations Specialist" },
                    { 30, "Airline Pilot" },
                    { 31, "All Occupation" },
                    { 32, "Ambulance Driver" },
                    { 33, "Attendant" },
                    { 34, "Amusement and Recreation Attendant" },
                    { 35, "Anesthesiologist" },
                    { 36, "Animal Breeder" },
                    { 37, "Animal Control Worker" },
                    { 38, "Animal Scientist" },
                    { 39, "Animal Trainer" },
                    { 40, "Anthropologist" },
                    { 41, "Archeologist" },
                    { 42, "Anthropology and Archeology Teacher" },
                    { 43, "Appraiser" },
                    { 44, "Assessors of Real Estate" },
                    { 45, "Arbitrator" },
                    { 46, "Architect" },
                    { 47, "Architectural and Civil Drafter" },
                    { 48, "Architectural and Engineering Manager" },
                    { 49, "Architecture Teacher" },
                    { 50, "Architecture and Engineering Occupation" },
                    { 27, "Service Technician" },
                    { 51, "Archivist" },
                    { 26, "Aircraft Mechanic" },
                    { 24, "Air Traffic Controller" },
                    { 1, "I'd perfer not to say" },
                    { 2, "Accountant" },
                    { 3, "Auditor" },
                    { 433, "Industrial-Organizational Psychologist" },
                    { 5, "Actuary" },
                    { 6, "Adhesive Bonding Machine Operator" },
                    { 7, "Tender" },
                    { 8, "Administrative Law Judge" },
                    { 9, "Administrative Services Manager" },
                    { 10, "Adult Basic and Secondary Education and Literacy Teacher" },
                    { 11, "Instructor" },
                    { 12, "Advertising Sales Agent" },
                    { 13, "Advertising and Promotions Manager" },
                    { 14, "Aerospace Engineering and Operations Technician" },
                    { 15, "Aerospace Engineer" },
                    { 16, "Agent" },
                    { 17, "Business Managers of Artist" },
                    { 18, "Agricultural Engineer" },
                    { 19, "Agricultural Equipment Operator" },
                    { 20, "Agricultural Inspector" },
                    { 21, "Agricultural Sciences Teacher" },
                    { 22, "Agricultural Worker" },
                    { 23, "Agricultural and Food Science Technician" },
                    { 25, "Aircraft Cargo Handling Supervisor" },
                    { 52, "Area" },
                    { 53, "Art Director" },
                    { 54, "Artist" },
                    { 83, "Biophysicist" },
                    { 84, "Biological Science Teacher" },
                    { 85, "Biological Scientist" },
                    { 86, "Biological Technician" },
                    { 87, "Biomedical Engineer" },
                    { 88, "Boilermaker" },
                    { 89, "Bookkeeping" },
                    { 90, "Brickmason" },
                    { 91, "Blockmason" },
                    { 92, "Bridge and Lock Tender" },
                    { 93, "Broadcast News Analyst" },
                    { 94, "Broadcast Technician" },
                    { 95, "Brokerage Clerk" },
                    { 96, "Budget Analyst" },
                    { 97, "Building Cleaning Worker" },
                    { 98, "Building and Grounds Cleaning and Maintenance Occupation" },
                    { 99, "Bus Driver" },
                    { 100, "Bu" },
                    { 101, "Truck Mechanic" },
                    { 102, "Diesel Engine Specialist" },
                    { 103, "Business Operations Specialist" },
                    { 104, "Business Teacher" },
                    { 105, "Busines" },
                    { 82, "Biochemist" },
                    { 81, "Billing and Posting Clerk" },
                    { 80, "Bill and Account Collector" },
                    { 79, "Bicycle Repairer" },
                    { 55, "Assembler" },
                    { 56, "Fabricator" },
                    { 57, "Astronomer" },
                    { 58, "Athlete" },
                    { 59, "Sports Competitor" },
                    { 60, "Athletic Trainer" },
                    { 61, "Atmospheric and Space Scientist" },
                    { 62, "Atmospheric" },
                    { 63, "Audio and Video Equipment Technician" },
                    { 64, "Audio-Visual and Multimedia Collections Specialist" },
                    { 65, "Audiologist" },
                    { 107, "Butcher" },
                    { 66, "Automotive Body and Related Repairer" },
                    { 68, "Repairer" },
                    { 69, "Automotive Service Technician" },
                    { 70, "Mechanic" },
                    { 71, "Automotive and Watercraft Service Attendant" },
                    { 72, "Avionics Technicians " },
                    { 73, "Baggage Porter" },
                    { 74, "Bellhop" },
                    { 75, "Bailiff" },
                    { 76, "Baker" },
                    { 77, "Barber" },
                    { 78, "Bartender" },
                    { 67, "Automotive Glass Installer" },
                    { 216, "Data Entry Keyer" },
                    { 4, "Actor" },
                    { 218, "Demonstrator" },
                    { 354, "Food Preparation and Serving Related Worker" },
                    { 355, "Food Scientist" },
                    { 356, "Technologist" },
                    { 357, "Food Server" },
                    { 358, "Food Service Manager" },
                    { 359, "Food and Tobacco Roasting" },
                    { 360, "Foreign Language and Literature Teacher" },
                    { 361, "Forensic Science Technician" },
                    { 362, "Forest Fire Inspector" },
                    { 363, "Prevention Specialist" },
                    { 364, "Forest and Conservation Technician" },
                    { 365, "Forest and Conservation Worker" },
                    { 366, "Forester" },
                    { 367, "Forestry and Conservation Science Teacher" },
                    { 368, "Forging Machine Setter" },
                    { 369, "Foundry Mold and Coremaker" },
                    { 370, "Funeral Attendant" },
                    { 371, "Funeral Service Manager" },
                    { 372, "Furniture Finisher" },
                    { 373, "Gaming Cage Worker" },
                    { 374, "Gaming Change Person" },
                    { 375, "Booth Cashier" },
                    { 376, "Gaming Dealer" },
                    { 353, "Food Preparation and Serving Related Occupation" },
                    { 377, "Gaming Manager" },
                    { 352, "Food Preparation Worker" },
                    { 350, "Food Batchmaker" },
                    { 327, "First-Line Supervisors of Food Preparation and Serving Worker" },
                    { 328, "First-Line Supervisors of Helper" },
                    { 329, "First-Line Supervisors of Housekeeping and Janitorial Worker" },
                    { 330, "First-Line Supervisors of Landscaping" },
                    { 331, "First-Line Supervisors of Mechanic" },
                    { 332, "First-Line Supervisors of Non-Retail Sales Worker" },
                    { 333, "First-Line Supervisors of Office and Administrative Support Worker" },
                    { 334, "First-Line Supervisors of Personal Service Worker" },
                    { 335, "First-Line Supervisors of Police and Detective" },
                    { 336, "First-Line Supervisors of Production and Operating Worker" },
                    { 337, "First-Line Supervisors of Protective Service Worker" },
                    { 338, "First-Line Supervisors of Retail Sales Worker" },
                    { 339, "First-Line Supervisors of Transportation and Material-Moving Machine and Vehicle Operator" },
                    { 340, "Fish and Game Warden" },
                    { 341, "Fisher" },
                    { 342, "Related Fishing Worker" },
                    { 343, "Fitness Trainer" },
                    { 344, "Aerobics Instructor" },
                    { 345, "Flight Attendant" },
                    { 346, "Floor Layer" },
                    { 347, "Floor Sander" },
                    { 348, "Finisher" },
                    { 349, "Floral Designer" },
                    { 351, "Food Cooking Machine Operator" },
                    { 378, "Gaming Service Worker" },
                    { 379, "Gaming Supervisor" },
                    { 380, "Gaming Surveillance Officer" },
                    { 409, "Healthcare Social Worker" },
                    { 410, "Healthcare Support Occupation" },
                    { 411, "Healthcare Support Worker" },
                    { 412, "Heat Treating Equipment Setter" },
                    { 413, "Heavy and Tractor-Trailer Truck Driver" },
                    { 414, "Highway Maintenance Worker" },
                    { 415, "Historian" },
                    { 416, "History Teacher" },
                    { 417, "Hoist and Winch Operator" },
                    { 418, "Home Appliance Repairer" },
                    { 419, "Home Economics Teacher" },
                    { 420, "Home Health Aide" },
                    { 421, "Host" },
                    { 422, "Hostess" },
                    { 423, "Human Resources Assistant" },
                    { 424, "Human Resources Manager" },
                    { 425, "Hunter" },
                    { 426, "Trapper" },
                    { 427, "Hydrologist" },
                    { 428, "Industrial Engineering Technician" },
                    { 429, "Industrial Engineer" },
                    { 431, "Industrial Production Manager" },
                    { 217, "Database Administrator" },
                    { 408, "Technical Worker" },
                    { 407, "Technical Occupation" },
                    { 406, "Healthcare Practitioner" },
                    { 405, "Health and Safety Engineer" },
                    { 381, "Gaming Investigator" },
                    { 382, "Gaming and Sports Book Writer" },
                    { 383, "Runner" },
                    { 384, "Gas Compressor and Gas Pumping Station Operator" },
                    { 385, "Gas Plant Operator" },
                    { 386, "General and Operations Manager" },
                    { 387, "Geographer" },
                    { 388, "Geography Teacher" },
                    { 389, "Geological and Petroleum Technician" },
                    { 390, "Geoscientist" },
                    { 391, "Glazier" },
                    { 326, "First-Line Supervisors of Fire Fighting and Prevention Worker" },
                    { 392, "Grader" },
                    { 394, "Graduate Teaching Assistant" },
                    { 395, "Graphic Designer" },
                    { 396, "Grinding and Polishing Worker" },
                    { 397, "Grinding" },
                    { 398, "Grounds Maintenance Worker" },
                    { 399, "Hairdresser" },
                    { 400, "Hazardous Materials Removal Worker" },
                    { 401, "Health Diagnosing and Treating Practitioner" },
                    { 402, "Health Educator" },
                    { 403, "Health Specialties Teacher" },
                    { 404, "Health Technologist" },
                    { 393, "Sorter" },
                    { 325, "First-Line Supervisors of Farming" },
                    { 430, "Industrial Machinery Mechanic" },
                    { 323, "First-Line Supervisors of Construction Trade" },
                    { 246, "Economist" },
                    { 247, "Editor" },
                    { 248, "Education Administrator" },
                    { 249, "Education Teacher" },
                    { 250, "Education" },
                    { 251, "Educational" },
                    { 252, "Electric Motor" },
                    { 253, "Electrical Engineer" },
                    { 254, "Electrical Power-Line Installer" },
                    { 255, "Electrical and Electronic Equipment Assembler" },
                    { 256, "Electrical and Electronics Drafter" },
                    { 257, "Electrical and Electronics Engineering Technician" },
                    { 258, "Electrical and Electronics Installer" },
                    { 259, "Electrical and Electronics Repairer" },
                    { 260, "Electrician" },
                    { 261, "Electro-Mechanical Technician" },
                    { 262, "Electromechanical Equipment Assembler" },
                    { 263, "Electronic Equipment Installer" },
                    { 264, "Electronic Home Entertainment Equipment Installer" },
                    { 265, "Electronics Engineer" },
                    { 266, "Elementary School Teacher" },
                    { 267, "Elevator Installer" },
                    { 268, "Eligibility Interviewer" },
                    { 245, "Economics Teacher" },
                    { 269, "Embalmer" },
                    { 244, "Earth Driller" },
                    { 242, "Driver/Sales Worker" },
                    { 324, "First-Line Supervisors of Correctional Officer" },
                    { 221, "Dental Hygienist" },
                    { 222, "Dental Laboratory Technician" },
                    { 223, "Dentist" },
                    { 224, "Derrick Operator" },
                    { 225, "Designer" },
                    { 226, "Desktop Publisher" },
                    { 227, "Detective" },
                    { 228, "Criminal Investigator" },
                    { 229, "Diagnostic Medical Sonographer" },
                    { 230, "Dietetic Technician" },
                    { 231, "Dietitian" },
                    { 232, "Nutritionist" },
                    { 233, "Dining Room and Cafeteria Attendant" },
                    { 234, "Bartender Helper" },
                    { 235, "Director" },
                    { 236, "Dishwasher" },
                    { 237, "Dispatcher" },
                    { 238, "Door-to-Door Sales Worker" },
                    { 239, "Drafter" },
                    { 219, "Product Promoter" },
                    { 240, "Dredge Operator" },
                    { 241, "Drilling and Boring Machine Tool Setter" },
                    { 243, "Drywall and Ceiling Tile Installers " },
                    { 220, "Dental Assistant" },
                    { 270, "Emergency Management Director" },
                    { 272, "Paramedic" },
                    { 300, "Fabric and Apparel Patternmaker" },
                    { 301, "Faller" },
                    { 302, "Family and General Practitioner" },
                    { 303, "Farm Equipment Mechanic" },
                    { 304, "Farm Labor Contractor" },
                    { 305, "Farm and Home Management Advisor" },
                    { 306, "Farmer" },
                    { 307, "Farming" },
                    { 308, "Farmworker" },
                    { 309, "Laborer" },
                    { 310, "Fashion Designer" },
                    { 311, "Fence Erector" },
                    { 312, "Fiberglass Laminator" },
                    { 313, "File Clerk" },
                    { 314, "Film and Video Editor" },
                    { 315, "Financial Analyst" },
                    { 316, "Financial Examiner" },
                    { 317, "Financial Manager" },
                    { 318, "Financial Specialist" },
                    { 319, "Fine Artist" },
                    { 320, "Fire Inspector" },
                    { 321, "Investigator" },
                    { 322, "Firefighter" },
                    { 299, "Fabric Mender" },
                    { 271, "Emergency Medical Technician" },
                    { 298, "Extruding" },
                    { 296, "Extruding and Drawing Machine Setter" },
                    { 273, "Engine and Other Machine Assembler" },
                    { 274, "Engineering Teacher" },
                    { 275, "Engineering Technician" },
                    { 276, "Engineer" },
                    { 277, "English Language and Literature Teacher" },
                    { 278, "Entertainer" },
                    { 279, "Performer" },
                    { 280, "Entertainment Attendant" },
                    { 281, "Related Worker" },
                    { 282, "Environmental Engineering Technician" },
                    { 283, "Environmental Engineer" },
                    { 284, "Environmental Science Teacher" },
                    { 285, "Environmental Science and Protection Technician" },
                    { 286, "Environmental Scientist" },
                    { 287, "Specialist" },
                    { 288, "Epidemiologist" },
                    { 289, "Etcher" },
                    { 290, "Engraver" },
                    { 291, "Excavating and Loading Machine and Dragline Operator" },
                    { 292, "Executive Secretarie" },
                    { 293, "Executive Administrative Assistant" },
                    { 294, "Explosives Worker" },
                    { 295, "Extraction Worker" },
                    { 297, "Extruding and Forming Machine Setter" }
                });

            migrationBuilder.InsertData(
                table: "personality",
                columns: new[] { "id", "personality_name" },
                values: new object[,]
                {
                    { 4, "I'd perfer not to say" },
                    { 3, "Somewhere in between" },
                    { 1, "Extrovert" },
                    { 2, "Introvert" }
                });

            migrationBuilder.InsertData(
                table: "preference_sex",
                columns: new[] { "id", "sex" },
                values: new object[,]
                {
                    { (byte)1, "Both" },
                    { (byte)2, "Male" },
                    { (byte)3, "Female" }
                });

            migrationBuilder.InsertData(
                table: "relationship",
                columns: new[] { "id", "relationship_type" },
                values: new object[,]
                {
                    { (byte)1, "I'm taken" },
                    { (byte)2, "It's complicated" },
                    { (byte)3, "I'm single" },
                    { (byte)4, "I'd perfer not to say" }
                });

            migrationBuilder.InsertData(
                table: "religion",
                columns: new[] { "id", "religion_name" },
                values: new object[,]
                {
                    { 303, "Wiccan" },
                    { 270, "Born Again Christian" },
                    { 271, "Associated Churches of Christ" },
                    { 272, "Elim" },
                    { 273, "Revival Centres" },
                    { 277, "Christian Outreach" },
                    { 275, "Assyrian Orthodox" },
                    { 276, "Chinese Christian" },
                    { 269, "Shiite Islam" },
                    { 274, "Commonwealth Covenant Church" },
                    { 268, "Ringatu" },
                    { 263, "Bible Baptist" },
                    { 266, "Ratana" },
                    { 265, "Plymouth Brethren" },
                    { 264, "Christian Science" },
                    { 278, "Christian Revival Crusade" },
                    { 262, "Kirati" },
                    { 261, "SaioZione" },
                    { 260, "Denomination not specified" },
                    { 259, "Orientalists' Cults" },
                    { 258, "Shaman" },
                    { 267, "Reformed Churches" },
                    { 279, "Cook Island Congregational" },
                    { 284, "Independent Evangelical Churches" },
                    { 281, "Ecumenical" },
                    { 302, "United Pentecostal" },
                    { 301, "Unification Church" },
                    { 300, "Tongan Methodist" },
                    { 205, "Latter Day Saints (Mormon)" },
                    { 299, "Theism" },
                    { 298, "Tenrikyo" },
                    { 297, "Sufi" },
                    { 296, "Samoan Congregational" },
                    { 295, "Religious Society of Friends" },
                    { 294, "Reformed Baptist" },
                    { 280, "Druid" },
                    { 293, "Other Church of Christ" },
                    { 291, "New life centres" },
                    { 290, "Metropolitan" },
                    { 289, "Mäori Religion" },
                    { 288, "Mahikari" },
                    { 287, "Liberal Catholic" },
                    { 286, "Korean Christian" },
                    { 285, "Independent Pentecostal" },
                    { 257, "Historics" },
                    { 283, "Independent Baptist" },
                    { 282, "Fundamentalist" },
                    { 292, "Open Brethren" },
                    { 256, "Ethnic Churches" },
                    { 251, "Other Chinese" },
                    { 254, "Rabidass" },
                    { 227, "Non-denominational Christian Churches" },
                    { 226, "Neuapostolische Kirche" },
                    { 225, "All Gospel Church" },
                    { 224, "Charismatic Evangelical Church" },
                    { 223, "Word of Faith" },
                    { 222, "Sunni Muslims" },
                    { 221, "Society for Krishna Consciousness" },
                    { 220, "Karaite" },
                    { 219, "Evangelical Reformists" },
                    { 218, "Evangelical Lutherans" },
                    { 217, "Church of Scientology" },
                    { 216, "Balts Believers" },
                    { 215, "Protestant Lutheran" },
                    { 214, "Protestant Reformed" },
                    { 213, "No Afiliation" },
                    { 212, "Bengali" },
                    { 211, "Arya Samajist" },
                    { 210, "Te koaua" },
                    { 209, "Kempsville Prebyterian Church" },
                    { 208, "All Nations Baptist" },
                    { 207, "Te Ran" },
                    { 228, "ConfucianismTaoism and Other Traditional Chinese" },
                    { 229, "Tribal" },
                    { 230, "Ahir" },
                    { 231, "Ahmadhya" },
                    { 253, "Mohamedan" },
                    { 252, "Baboojee" },
                    { 250, "Peniel Tabernacle" },
                    { 249, "La Voix de la Delivrance" },
                    { 206, "International Church of the Foursquare Gospel" },
                    { 248, "Eglise Chrétienne" },
                    { 247, "Other Muslims" },
                    { 246, "Sanatanist" }
                });

            migrationBuilder.InsertData(
                table: "religion",
                columns: new[] { "id", "religion_name" },
                values: new object[,]
                {
                    { 245, "Other Hindu" },
                    { 244, "Vedic" },
                    { 255, "Telegu Speaking" },
                    { 243, "Vaish" },
                    { 241, "Témoin de Jehovah" },
                    { 240, "Tamil and Tamil Hindu" },
                    { 239, "Rajput" },
                    { 238, "Puranic" },
                    { 237, "Mission Salut et Guerison" },
                    { 236, "Marathi & Marathi Hindu" },
                    { 235, "Kabir Panthis" },
                    { 234, "Christian Tamil" },
                    { 233, "Chinese" },
                    { 232, "Aryan" },
                    { 242, "Telegu and Telegu Hindu" },
                    { 304, "Yoga" },
                    { 361, "Baptists Fraternity Union" },
                    { 306, "Hauhau" },
                    { 379, "Other Congregational Churches" },
                    { 378, "Other Charismatic Churches" },
                    { 377, "Other Assemblies" },
                    { 376, "Other African Apostolic Churches" },
                    { 375, "Pinkster Protestante Kerk" },
                    { 374, "Nederduits Hervormde Kerk" },
                    { 373, "NA: Institution" },
                    { 372, "International Fellowship of Christian Church" },
                    { 371, "Bandla Lama Nazaretha" },
                    { 370, "Afrikaanse Protestante Kerk" },
                    { 369, "Other Faiths" },
                    { 368, "Ibandlalama Nazaretha" },
                    { 367, "Zion Christian Church" },
                    { 366, "Other Zionist Churches" },
                    { 365, "Other African Independent Churches" },
                    { 364, "Ethiopian Churches" },
                    { 363, "Apostolic Faith Mission of SA" },
                    { 362, "African Traditional Belief" },
                    { 360, "Byzantine Catholic Church" },
                    { 359, "Reformed Christian" },
                    { 358, "Fraternity Church" },
                    { 380, "Other Pentecostal Churches" },
                    { 381, "Other Prebyterian Churches" },
                    { 382, "St. Engenas Zion Christian Church" },
                    { 383, "St. John's Apostolic Church" },
                    { 404, "Hoa hao - Hoa Hao" },
                    { 204, "African Instituted Churches" },
                    { 403, "Cao daii - Cao Dai" },
                    { 402, "Hoi giao - Muslim" },
                    { 401, "Tin lanh - Protestant" },
                    { 400, "Cong giao - Catholic" },
                    { 399, "Phat giao - Buddhist" },
                    { 398, "Church of Tuvalu" },
                    { 397, "New Testament Church" },
                    { 396, "Ekalesia Kelisiano Tuvalu" },
                    { 357, "Evangelic Methodist Church" },
                    { 395, "Brethren Assembly" },
                    { 393, "Pentecostal Evangelical Full Gospel" },
                    { 392, "Orisha" },
                    { 391, "Constitutional Church of Tonga" },
                    { 390, "Tokaikolo Christian Church" },
                    { 389, "Free Wesleyan Church" },
                    { 388, "Free Church of Tonga" },
                    { 387, "Church of Tonga" },
                    { 386, "Protestant Evangelical" },
                    { 385, "Other Adventist Churches" },
                    { 384, "Full Gospel Church of God" },
                    { 394, "Prebyterian Congregational" },
                    { 305, "Zen Buddhist" },
                    { 356, "Evangelic of Augsburg Affiliation" },
                    { 354, "IslamJudaism" },
                    { 327, "Philippine Benevolent Missionaries Association" },
                    { 326, "Missionary Baptist Churches of the Philippines" },
                    { 325, "International Baptist Missionary Fellowship" },
                    { 324, "Iglesia Evangelista Methodista en Las Filipinas" },
                    { 323, "Iglesia ni Cristo" },
                    { 322, "Convention of the Philippine Baptist Church" },
                    { 321, "Aglipay" },
                    { 320, "Evangelical Christian" },
                    { 319, "None or Refused" },
                    { 318, "Modekngei" },
                    { 317, "Scheduled Castes" },
                    { 316, "QadianiAhmadi" },
                    { 315, "Non-Christian" },
                    { 314, "Australian Christian Church" },
                    { 313, "Uniting Church" },
                    { 312, "Ekalesia Niue" },
                    { 311, "Object" },
                    { 310, "Mäori Christian" },
                    { 309, "Apostolic Church of New Zealand" },
                    { 308, "Brethren Exclusive" },
                    { 307, "Reformat" },
                    { 328, "United Church of Christ" },
                    { 329, "Other Baptist Churches" },
                    { 330, "Episcopal" },
                    { 331, "Southern Baptist" },
                    { 353, "Eastern religion" },
                    { 352, "Non-Apostolic" },
                    { 351, "Maná" },
                    { 350, "Community Church" },
                    { 349, "Aoga Tusi Paia" },
                    { 348, "Peace Chapel" },
                    { 347, "Samoa Evangelism" },
                    { 346, "Voice of Christ" },
                    { 345, "CCCJS" },
                    { 344, "Worship Centre" },
                    { 355, "Buddhism Sikh" },
                    { 343, "Mosaic" },
                    { 341, "Evangelic Synodal Prebyterian" },
                    { 340, "Christian of Old Rite" },
                    { 339, "Daesoonjillihoi" },
                    { 338, "Taejong-gyo" },
                    { 337, "Ch'ondo-gyo" },
                    { 336, "Won Buddhist" },
                    { 335, "Didn't answer" },
                    { 334, "Evangelic Augustan Confession" },
                    { 333, "Other Methodist Churches" },
                    { 332, "United Methodist Church" },
                    { 342, "Christian by Gospel" },
                    { 203, "Church of God in Jamaica" },
                    { 95, "God is Love" },
                    { 201, "Revived" },
                    { 72, "Mennonite" },
                    { 71, "Greek Orthodox" },
                    { 70, "Greek Oriental" },
                    { 69, "Church of England" },
                    { 68, "Christengmeinschaft" },
                    { 67, "Unknown" },
                    { 66, "Oriental Christian" },
                    { 65, "Zoroastrianism" },
                    { 64, "Theism, nec" },
                    { 63, "Oriental Orthodox" },
                    { 62, "Assyrian Apostolic" },
                    { 61, "Secular Beliefs" },
                    { 60, "Australian Aboriginal Traditional Religion" },
                    { 59, "Nature and earth based religions" },
                    { 58, "Japanese Religions" },
                    { 57, "Prebyterian and Reformed" },
                    { 56, "Chinese Religions" },
                    { 55, "Christian nfd" },
                    { 54, "Jehovah's Witnesses" },
                    { 53, "Other Protestant" },
                    { 52, "United Church" },
                    { 73, "New Apostolic" },
                    { 51, "Sikh" },
                    { 74, "Old Catholic Church" },
                    { 76, "Unification" },
                    { 98, "Other Traditional Evangelical" },
                    { 97, "Other Evangelical Pentecostal" },
                    { 202, "Other Church of God" },
                    { 94, "Espiritia" },
                    { 93, "Christian Congregation of Brazil" },
                    { 92, "Candomble" },
                    { 91, "Brasilian Apostolic Catholic" },
                    { 90, "Badimo" },
                    { 89, "Ethiopian Orthodox" },
                    { 88, "Non-denominational" },
                    { 87, "African Methodist Episcopal Church" },
                    { 86, "Wesleyan" },
                    { 85, "Nazarene" },
                    { 84, "Christian" },
                    { 83, "Greek Church" },
                    { 82, "None" },
                    { 81, "Other Non-Christians" },
                    { 80, "Mormon" },
                    { 79, "Assembly of God" },
                    { 78, "Free Christian Community" },
                    { 77, "Christian Community" },
                    { 75, "Shinto" },
                    { 50, "Lutheran" },
                    { 49, "Latter Day Saints" },
                    { 48, "Judaism" },
                    { 21, "Pentecostal" },
                    { 20, "Methodist" },
                    { 19, "Jewish" },
                    { 18, "Jehovah Witness" },
                    { 17, "Hindu" },
                    { 16, "Church of God" },
                    { 15, "Brethren" },
                    { 14, "Baptist" },
                    { 13, "Anglican" },
                    { 12, "Not Stated" },
                    { 11, "Believers without denomination" },
                    { 10, "Bektashism" },
                    { 9, "Refused to answer" },
                    { 8, "Other Christians" },
                    { 7, "Other" },
                    { 6, "Orthodox" },
                    { 5, "Muslim" },
                    { 4, "Evangelical" },
                    { 3, "Catholic" },
                    { 2, "Atheist" },
                    { 1, "I'd perfer not to say" },
                    { 22, "Prebyterian" },
                    { 23, "Rastafarian" },
                    { 24, "Roman Catholic" },
                    { 25, "Seventh Day Adventist" },
                    { 47, "Eastern Orthodox" },
                    { 46, "Druze" },
                    { 45, "Church of Christ" },
                    { 44, "Buddhist" },
                    { 43, "Other Religions and Persuasions" },
                    { 42, "Protestant" },
                    { 41, "Adventist" },
                    { 40, "Shar-fadinian" },
                    { 39, "Molokai" },
                    { 38, "Yeshiva's witness" },
                    { 99, "Roman Apostolic Catholic" },
                    { 37, "Pagan" },
                    { 35, "Armenian Apostolic" },
                    { 34, "Not Declared" },
                    { 33, "Spiritualist" },
                    { 32, "Salvation Army" },
                    { 31, "Moravian" },
                    { 30, "Islam " },
                    { 29, "Baha'i" },
                    { 28, "Not Specified" },
                    { 27, "No Religion" },
                    { 26, "Other Religions" },
                    { 36, "Armenian Orthodox" },
                    { 100, "Umbanda" },
                    { 96, "Orthodox Catholic" },
                    { 102, "Messianica" },
                    { 174, "Maronite church" },
                    { 173, "Armenian church" },
                    { 172, "Non-believers" },
                    { 171, "Greek Catholic" },
                    { 170, "Calvinist" },
                    { 169, "Oriental" },
                    { 168, "Harriste" },
                    { 167, "Celestial" },
                    { 166, "Holy Spirit" },
                    { 165, "Cook Islands Christian Church" },
                    { 164, "Apostolic" },
                    { 163, "No religion, Agnostic, Atheist" },
                    { 162, "Church of God nos" },
                    { 161, "Polish National Catholic Church" },
                    { 160, "Other Eastern religions" },
                    { 159, "Standard Church" },
                    { 158, "Hutterite" },
                    { 101, "Universal of the Kingdom of God" },
                    { 156, "Canadian Reformed Church" },
                    { 155, "Christians, n.i.e." },
                    { 154, "Brethren in Christ" },
                    { 175, "Czechoslovak Hussite Church" },
                    { 176, "Silesian Evangelical Church" },
                    { 177, "Other Evangelical Churches" },
                    { 178, "Hare Rama Hare Krishna" },
                    { 200, "Church of God of Prophecy" },
                    { 199, "Pantheism" },
                    { 198, "Lapsed Roman Catholic" },
                    { 197, "Church of Ireland" },
                    { 196, "Not Asked" },
                    { 195, "Confucian" },
                    { 194, "Christian Orthodox" },
                    { 193, "Islamic Congregation" },
                    { 192, "Other Lutheran Churches" },
                    { 191, "Free Church in Finland" },
                    { 153, "Apostolic Christian Church" },
                    { 190, "Other Apostolic Churches" },
                    { 188, "Congregational" },
                    { 187, "Christian Free Congregations" },
                    { 186, "Taara or Earth Believer" },
                    { 185, "Charismatic Episcopal Church" },
                    { 184, "Ukrainian Greek-Catholic Church" },
                    { 183, "Russian Catholic Orthodox Church" },
                    { 182, "Estonian Ancient Belief" },
                    { 181, "Church of Christian Fellowship" },
                    { 180, "Church of Charismatic Fellowship" },
                    { 179, "Old Believers" },
                    { 189, "Full Gospel Church" },
                    { 152, "Ukrainian Catholic" },
                    { 157, "Canadian and American Reformed Church" },
                    { 150, "Other Orthodox Churches" },
                    { 123, "Dutch Reformed" },
                    { 122, "Doukhobors" },
                    { 151, "Other Reformed Church" },
                    { 120, "Church of Nazarene" },
                    { 119, "Church of Jesus Christ of Latter-day Saints" },
                    { 118, "Christian Reformed Church" },
                    { 117, "Christian or Plymouth Brethren" },
                    { 116, "Christian and Mission Alliance" },
                    { 115, "Christian Congregational" },
                    { 114, "Christadelphian" },
                    { 113, "Charismatic Renewal" },
                    { 112, "Associated Gospel" },
                    { 111, "Antiochian Orthodox Christian" },
                    { 110, "Agnostic" },
                    { 109, "Aboriginal spirituality" },
                    { 108, "Traditional" },
                    { 107, "Animist" },
                    { 106, "Yiddish" },
                    { 105, "Armeno-Gregorian" },
                    { 104, "New Testament Church of God" },
                    { 103, "Umbanda e Candomblé" },
                    { 124, "Evangelical Free Church" },
                    { 125, "Evangelical Missionary Church" },
                    { 121, "Coptic Orthodox" },
                    { 127, "Gnostic" },
                    { 149, "Other Catholic" },
                    { 148, "Zoroastrian" },
                    { 147, "Worldwide Church of God" },
                    { 146, "Vineyard Christian Fellowship" },
                    { 145, "Unity-New Thought-Pantheist" },
                    { 126, "Free Methodists" },
                    { 143, "Ukrainian Orthodox" },
                    { 142, "Taoist" },
                    { 141, "Swedenborgian (New Church)" },
                    { 140, "Serbian Orthodox" },
                    { 139, "Scientology" },
                    { 144, "Unitarian" },
                    { 137, "Russian Orthodox" },
                    { 138, "Satanist" },
                    { 128, "Humanist" },
                    { 130, "Jains" },
                    { 131, "Mission de l'Esprit Saint" },
                    { 129, "Interdenominational" },
                    { 133, "Protestant nfd" },
                    { 134, "Quakers" },
                    { 135, "Reorganized Church of Latter-day Saints" },
                    { 136, "Romanian Orthodox" },
                    { 132, "New Age" }
                });

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "id", "role_name" },
                values: new object[,]
                {
                    { (byte)1, "ANTHERA_USER" },
                    { (byte)2, "ANTHERA_ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "sexuality",
                columns: new[] { "id", "sexuality_type" },
                values: new object[,]
                {
                    { (byte)4, "I'm straight" },
                    { (byte)1, "I'm bisexual" },
                    { (byte)2, "I'm gay" },
                    { (byte)3, "Ask me" }
                });

            migrationBuilder.InsertData(
                table: "smoking",
                columns: new[] { "id", "smoking_type" },
                values: new object[,]
                {
                    { (byte)3, "I smoke occasionally" },
                    { (byte)4, "I don't smoke" },
                    { (byte)1, "I'm a heavy smoker" },
                    { (byte)2, "I hate smoking" },
                    { (byte)5, "I'd perfer not to say" }
                });

            migrationBuilder.CreateIndex(
                name: "children_type",
                table: "children",
                column: "children_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "drinking_type",
                table: "drinking",
                column: "drinking_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "education_level_name",
                table: "education_level",
                column: "education_level_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "colour",
                table: "eye_colour",
                column: "colour",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "gender_name",
                table: "gender",
                column: "gender_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "colour",
                table: "hair_colour",
                column: "colour",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "here_to_type",
                table: "here_to",
                column: "here_to_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "interest_type",
                table: "interests",
                column: "interest_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "title",
                table: "job_title",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "language_name",
                table: "language",
                column: "language_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "personality_name",
                table: "personality",
                column: "personality_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FKpreference611362",
                table: "preference",
                column: "preference_sex_id");

            migrationBuilder.CreateIndex(
                name: "sex",
                table: "preference_sex",
                column: "sex",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FKrefresh_to567261",
                table: "refresh_token",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "relationship_type",
                table: "relationship",
                column: "relationship_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "religion_name",
                table: "religion",
                column: "religion_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "role_name",
                table: "role",
                column: "role_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "sexuality_type",
                table: "sexuality",
                column: "sexuality_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "smoking_type",
                table: "smoking",
                column: "smoking_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "email_address",
                table: "user",
                column: "email_address",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FKuser994439",
                table: "user",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "FKuser_info865355",
                table: "user_info",
                column: "children_id");

            migrationBuilder.CreateIndex(
                name: "FKuser_info390466",
                table: "user_info",
                column: "drinking_id");

            migrationBuilder.CreateIndex(
                name: "FKuser_info490875",
                table: "user_info",
                column: "education_level_id");

            migrationBuilder.CreateIndex(
                name: "FKuser_info751412",
                table: "user_info",
                column: "eye_colour_id");

            migrationBuilder.CreateIndex(
                name: "FKuser_info498432",
                table: "user_info",
                column: "gender_id");

            migrationBuilder.CreateIndex(
                name: "FKuser_info890322",
                table: "user_info",
                column: "hair_colour_id");

            migrationBuilder.CreateIndex(
                name: "FKuser_info830718",
                table: "user_info",
                column: "here_to_id");

            migrationBuilder.CreateIndex(
                name: "FKuser_info963064",
                table: "user_info",
                column: "job_title_id");

            migrationBuilder.CreateIndex(
                name: "FKuser_info129223",
                table: "user_info",
                column: "personality_id");

            migrationBuilder.CreateIndex(
                name: "preference_id",
                table: "user_info",
                column: "preference_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FKuser_info718147",
                table: "user_info",
                column: "relationship_id");

            migrationBuilder.CreateIndex(
                name: "FKuser_info800964",
                table: "user_info",
                column: "religion_id");

            migrationBuilder.CreateIndex(
                name: "FKuser_info840976",
                table: "user_info",
                column: "sexuality_id");

            migrationBuilder.CreateIndex(
                name: "FKuser_info916383",
                table: "user_info",
                column: "smoking_id");

            migrationBuilder.CreateIndex(
                name: "user_id",
                table: "user_info",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FKuser_info_434712",
                table: "user_info_interest",
                column: "interests_id");

            migrationBuilder.CreateIndex(
                name: "FKuser_info_837564",
                table: "user_info_language",
                column: "user_info_id");

            migrationBuilder.CreateIndex(
                name: "FKuser_info_972894",
                table: "user_info_photo",
                column: "user_info_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "refresh_token");

            migrationBuilder.DropTable(
                name: "user_info_interest");

            migrationBuilder.DropTable(
                name: "user_info_language");

            migrationBuilder.DropTable(
                name: "user_info_photo");

            migrationBuilder.DropTable(
                name: "interests");

            migrationBuilder.DropTable(
                name: "language");

            migrationBuilder.DropTable(
                name: "photo");

            migrationBuilder.DropTable(
                name: "user_info");

            migrationBuilder.DropTable(
                name: "children");

            migrationBuilder.DropTable(
                name: "drinking");

            migrationBuilder.DropTable(
                name: "education_level");

            migrationBuilder.DropTable(
                name: "eye_colour");

            migrationBuilder.DropTable(
                name: "gender");

            migrationBuilder.DropTable(
                name: "hair_colour");

            migrationBuilder.DropTable(
                name: "here_to");

            migrationBuilder.DropTable(
                name: "job_title");

            migrationBuilder.DropTable(
                name: "personality");

            migrationBuilder.DropTable(
                name: "preference");

            migrationBuilder.DropTable(
                name: "relationship");

            migrationBuilder.DropTable(
                name: "religion");

            migrationBuilder.DropTable(
                name: "sexuality");

            migrationBuilder.DropTable(
                name: "smoking");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "preference_sex");

            migrationBuilder.DropTable(
                name: "role");
        }
    }
}
