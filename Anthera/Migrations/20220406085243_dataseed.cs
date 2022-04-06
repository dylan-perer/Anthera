using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Anthera_API.Migrations
{
    public partial class dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "children",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    children_type = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_children", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "drinking",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    drinking_type = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drinking", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "education_level",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    education_level_name = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_education_level", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "eye_colour",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    colour = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eye_colour", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gender",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gender_name = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gender", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hair_colour",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    colour = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hair_colour", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "here_to",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    here_to_type = table.Column<string>(unicode: false, maxLength: 40, nullable: false)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    interest_type = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    language_name = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personality_name = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    photo_url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "preference_sex",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sex = table.Column<string>(unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_preference_sex", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "relationship",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    relationship_type = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    religion_name = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_religion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    role_name = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sexuality",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sexuality_type = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sexuality", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "smoking",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    smoking_type = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    email_address = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    password = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    profile_picture_url = table.Column<string>(type: "text", nullable: true),
                    last_online = table.Column<DateTime>(type: "datetime", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    refresh_token_value = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(nullable: false),
                    gender_id = table.Column<byte>(nullable: false),
                    preference_id = table.Column<int>(nullable: false),
                    dob = table.Column<DateTime>(type: "datetime", nullable: false),
                    city = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    ip_address = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    job_title_id = table.Column<int>(nullable: false),
                    company_name = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    school_university = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    about_me = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    relationship_id = table.Column<byte>(nullable: false),
                    sexuality_id = table.Column<byte>(nullable: false),
                    height = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('I''d prefer not to say')"),
                    weight = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('I''d prefer not to say')"),
                    eye_colour_id = table.Column<byte>(nullable: false),
                    hair_colour_id = table.Column<byte>(nullable: false),
                    children_id = table.Column<byte>(nullable: false),
                    smoking_id = table.Column<byte>(nullable: false),
                    drinking_id = table.Column<byte>(nullable: false),
                    here_to_id = table.Column<byte>(nullable: false),
                    photo_limit = table.Column<byte>(nullable: false, defaultValueSql: "((6))"),
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
                    table.PrimaryKey("PK__user_inf__A6F5C667F082FDD9", x => new { x.user_info_id, x.interests_id, x.user_infouser_id });
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
                    table.PrimaryKey("PK__user_inf__62B1F96BC181890F", x => new { x.language_id, x.user_info_id, x.user_infouser_id });
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
                    table.PrimaryKey("PK__user_inf__29B5C7E5FFEC7476", x => new { x.photo_id, x.user_info_id, x.user_infouser_id });
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
                    { 571, "Network and Computer Systems Administrator" },
                    { 580, "Teacher" },
                    { 579, "Nursing Instructor" },
                    { 578, "Nursing Aide" },
                    { 577, "Nuclear Technician" },
                    { 574, "Nuclear Engineer" },
                    { 575, "Nuclear Medicine Technologist" },
                    { 581, "Obstetrician" },
                    { 573, "Nonfarm Animal Caretaker" },
                    { 572, "New Accounts Clerk" },
                    { 576, "Nuclear Power Reactor Operator" },
                    { 582, "Gynecologist" },
                    { 586, "Occupational Therapy Aide" },
                    { 584, "Occupational Health and Safety Technician" },
                    { 585, "Occupational Therapist" },
                    { 587, "Occupational Therapy Assistant" },
                    { 588, "Office Clerk" },
                    { 589, "Office Machine Operator" },
                    { 590, "Office and Administrative Support Worker" },
                    { 591, "Operating Engineer" },
                    { 592, "Other Construction Equipment Operator" },
                    { 593, "Operations Research Analyst" },
                    { 594, "Ophthalmic Laboratory Technician" },
                    { 583, "Occupational Health and Safety Specialist" },
                    { 570, "Natural Sciences Manager" },
                    { 551, "Mobile Heavy Equipment Mechanic" },
                    { 568, "Musician" },
                    { 545, "Millwright" },
                    { 546, "Mine Cutting and Channeling Machine Operator" },
                    { 547, "Mine Shuttle Car Operator" },
                    { 548, "Mining Machine Operator" },
                    { 549, "Mining and Geological Engineer" },
                    { 550, "Mixing and Blending Machine Setter" },
                    { 595, "Optician" },
                    { 552, "Model Maker" },
                    { 553, "Molder" },
                    { 554, "Motion Picture Projectionist" },
                    { 555, "Motor Vehicle Operator" },
                    { 556, "Motorboat Mechanic" },
                    { 557, "Motorboat Operator" },
                    { 558, "Motorcycle Mechanic" },
                    { 559, "Multimedia Artist" },
                    { 560, "Animator" },
                    { 561, "Multiple Machine Tool Setter" },
                    { 562, "Museum Technician" },
                    { 563, "Conservator" },
                    { 564, "Music Director" },
                    { 565, "Composer" },
                    { 566, "Musical Instrument Repairer" },
                    { 567, "Tuner" },
                    { 569, "Singer" },
                    { 596, "Optometrist" },
                    { 615, "Patternmaker" },
                    { 598, "Order Clerk" },
                    { 626, "Petroleum Pump System Operator" },
                    { 628, "Pharmacy Aide" },
                    { 629, "Pharmacy Technician" },
                    { 630, "Philosophy and Religion Teacher" },
                    { 631, "Photographer" },
                    { 632, "Photographic Process Worker" },
                    { 633, "Processing Machine Operator" },
                    { 634, "Physical Scientist" },
                    { 635, "Physical Therapist Aide" },
                    { 636, "Physical Therapist Assistant" },
                    { 637, "Physical Therapist" },
                    { 638, "Physician Assistant" },
                    { 639, "Physician" },
                    { 640, "Surgeon" },
                    { 641, "Physicist" },
                    { 642, "Physics Teacher" },
                    { 643, "Pile-Driver Operator" },
                    { 644, "Pipelayer" },
                    { 645, "Plant and System Operator" },
                    { 646, "Plasterer" },
                    { 647, "Stucco Mason" },
                    { 648, "Plating and Coating Machine Setter" },
                    { 649, "Plumber" },
                    { 625, "Petroleum Engineer" },
                    { 597, "Oral and Maxillofacial Surgeon" },
                    { 624, "Pesticide Handler" },
                    { 622, "Personal Financial Advisor" },
                    { 599, "Orthodontist" },
                    { 600, "Orthotist" },
                    { 601, "Prosthetist" },
                    { 602, "Outdoor Power Equipment and Other Small Engine Mechanic" },
                    { 603, "Packaging and Filling Machine Operator" },
                    { 604, "Packer" },
                    { 605, "Packager" },
                    { 606, "Painter" },
                    { 607, "Painting" },
                    { 608, "Paper Goods Machine Setter" },
                    { 609, "Paperhanger" },
                    { 610, "Paralegal" },
                    { 611, "Legal Assistant" },
                    { 612, "Parking Enforcement Worker" },
                    { 613, "Parking Lot Attendant" },
                    { 614, "Parts Salesperson" },
                    { 544, "Milling and Planing Machine Setter" },
                    { 616, "Paving" },
                    { 617, "Payroll and Timekeeping Clerk" },
                    { 618, "Pediatrician" },
                    { 619, "Personal Care Aide" },
                    { 620, "Personal Care and Service Occupation" },
                    { 621, "Personal Care and Service Worker" },
                    { 623, "Pest Control Worker" },
                    { 543, "Middle School Teacher" },
                    { 524, "Medical Assistant" },
                    { 541, "Meter Reader" },
                    { 463, "Legal Secretary" },
                    { 464, "Legal Support Worker" },
                    { 465, "Legislator" },
                    { 466, "Librarian" },
                    { 467, "Library Assistant" },
                    { 468, "Library Science Teacher" },
                    { 469, "Library Technician" },
                    { 470, "Licensed Practical and Licensed Vocational Nurse" },
                    { 471, "Life Scientist" },
                    { 472, "Lifeguard" },
                    { 473, "Light Truck or Delivery Services Driver" },
                    { 474, "Loading Machine Operator" },
                    { 475, "Loan Interviewer" },
                    { 476, "Clerk" },
                    { 477, "Loan Officer" },
                    { 478, "Locksmith" },
                    { 479, "Safe Repairer" },
                    { 480, "Locomotive Engineer" },
                    { 481, "Locomotive Firer" },
                    { 482, "Lodging Manager" },
                    { 483, "Log Grader" },
                    { 484, "Scaler" },
                    { 485, "Logging Equipment Operator" },
                    { 462, "Legal Occupation" },
                    { 486, "Logging Worker" },
                    { 461, "Layout Worker" },
                    { 459, "Law Teacher" },
                    { 436, "Instructional Coordinator" },
                    { 437, "Insulation Worker" },
                    { 438, "Insurance Appraiser" },
                    { 439, "Insurance Claim" },
                    { 440, "Policy Processing Clerk" },
                    { 441, "Insurance Sales Agent" },
                    { 442, "Insurance Underwriter" },
                    { 443, "Interior Designer" },
                    { 444, "Internist" },
                    { 445, "Interpreter" },
                    { 446, "Translator" },
                    { 447, "Interviewer" },
                    { 448, "Janitor" },
                    { 449, "Cleaner" },
                    { 450, "Jeweler" },
                    { 451, "Precious Stone and Metal Worker" },
                    { 452, "Judge" },
                    { 453, "Judicial Law Clerk" },
                    { 454, "Kindergarten Teacher" },
                    { 455, "Landscape Architect" },
                    { 456, "Landscaping and Groundskeeping Worker" },
                    { 457, "Lathe and Turning Machine Tool Setter" },
                    { 458, "Laundry and Dry-Cleaning Worker" },
                    { 460, "Lawyer" },
                    { 487, "Logisticians " },
                    { 488, "Machine Feeder" },
                    { 489, "Machinist" },
                    { 518, "Mechanical Drafter" },
                    { 519, "Mechanical Engineering Technician" },
                    { 520, "Mechanical Engineer" },
                    { 521, "Media and Communication Equipment Worker" },
                    { 522, "Media and Communication Worker" },
                    { 523, "Medical Appliance Technician" },
                    { 650, "Podiatrist" },
                    { 525, "Medical Equipment Preparer" },
                    { 526, "Medical Equipment Repairer" },
                    { 527, "Health Information Technician" },
                    { 528, "Medical Scientist" },
                    { 529, "Medical Secretary" },
                    { 530, "Medical Transcriptionist" },
                    { 531, "Medical and Clinical Laboratory Technician" },
                    { 532, "Medical and Clinical Laboratory Technologist" },
                    { 533, "Medical and Health Services Manager" },
                    { 534, "Mental Health Counselor" },
                    { 535, "Mental Health and Substance Abuse Social Worker" },
                    { 536, "Merchandise Displayer" },
                    { 537, "Window Trimmer" },
                    { 538, "Metal Worker" },
                    { 539, "Plastic Worker" },
                    { 540, "Metal-Refining Furnace Operator" },
                    { 517, "Mechanical Door Repairer" },
                    { 516, "Mathematician" },
                    { 515, "Mathematical Technician" },
                    { 514, "Mathematical Science Teacher" },
                    { 490, "Maid" },
                    { 491, "Housekeeping Cleaner" },
                    { 492, "Mail Clerk" },
                    { 493, "Mail Machine Operator" },
                    { 494, "Maintenance Worker" },
                    { 495, "Maintenance and Repair Worker" },
                    { 496, "Makeup Artist" },
                    { 497, "Management Analyst" },
                    { 498, "Management Occupation" },
                    { 499, "Manager" },
                    { 500, "Manicurist" },
                    { 542, "Microbiologist" },
                    { 501, "Pedicurist" },
                    { 503, "Marine Engineer" },
                    { 504, "Naval Architect" },
                    { 505, "Market Research Analyst" },
                    { 506, "Marketing Specialist" },
                    { 507, "Marketing Manager" },
                    { 508, "Marriage and Family Therapist" },
                    { 509, "Massage Therapist" },
                    { 510, "Material Moving Worker" },
                    { 511, "Materials Engineer" },
                    { 512, "Materials Scientist" },
                    { 513, "Mathematical Science Occupation" },
                    { 502, "Manufactured Building and Mobile Home Installer" },
                    { 651, "Police and Sheriff's Patrol Officer" },
                    { 670, "Private Detective" },
                    { 653, "Political Scientist" },
                    { 790, "Substance Abuse and Behavioral Disorder Counselor" },
                    { 791, "Subway and Streetcar Operator" },
                    { 792, "Surgical Technologist" },
                    { 793, "Survey Researcher" },
                    { 794, "Surveying and Mapping Technician" },
                    { 795, "Surveyor" },
                    { 796, "Switchboard Operator" },
                    { 797, "Tailor" },
                    { 798, "Tank Car" },
                    { 799, "Taper" },
                    { 800, "Tax Examiner" },
                    { 801, "Collector" },
                    { 802, "Tax Preparer" },
                    { 803, "Taxi Driver" },
                    { 804, "Chauffeur" },
                    { 805, "Teacher Assistant" },
                    { 806, "Team Assembler" },
                    { 807, "Technical Writer" },
                    { 808, "Telecommunications Equipment Installer" },
                    { 809, "Telecommunications Line Installer" },
                    { 810, "Telemarketer" },
                    { 811, "Telephone Operator" },
                    { 812, "Teller" },
                    { 789, "Fitter" },
                    { 813, "Terrazzo Worker" },
                    { 788, "Structural Metal Fabricator" },
                    { 786, "Stonemason" },
                    { 763, "Slaughterer" },
                    { 764, "Meat Packer" },
                    { 765, "Slot Supervisor" },
                    { 766, "Social Science Research Assistant" },
                    { 767, "Social Sciences Teacher" },
                    { 768, "Social Scientist" },
                    { 769, "Social Work Teacher" },
                    { 770, "Social Worker" },
                    { 771, "Social and Community Service Manager" },
                    { 772, "Social and Human Service Assistant" },
                    { 773, "Sociologist" },
                    { 774, "Sociology Teacher" },
                    { 775, "Software Developer" },
                    { 776, "Soil and Plant Scientist" },
                    { 777, "Sound Engineering Technician" },
                    { 778, "Special Education Teacher" },
                    { 779, "Speech-Language Pathologist" },
                    { 780, "Stationary Engineer" },
                    { 781, "Boiler Operator" },
                    { 782, "Statistical Assistant" },
                    { 783, "Statistician" },
                    { 784, "Stock Clerk" },
                    { 785, "Order Filler" },
                    { 787, "Structural Iron and Steel Worker" },
                    { 762, "Skincare Specialist" },
                    { 814, "Textile Bleaching and Dyeing Machine Operator" },
                    { 816, "Textile Knitting and Weaving Machine Setter" },
                    { 844, "Usher" },
                    { 845, "Veterinarian" },
                    { 846, "Veterinary Assistant" },
                    { 847, "Laboratory Animal Caretaker" },
                    { 848, "Veterinary Technologist" },
                    { 849, "Vocational Education Teacher" },
                    { 850, "Waiter" },
                    { 851, "Waitress" },
                    { 852, "Watch Repairer" },
                    { 853, "Water and Wastewater Treatment Plant and System Operator" },
                    { 854, "Weigher" },
                    { 855, "Welder" },
                    { 856, "Welding" },
                    { 857, "Wellhead Pumper" },
                    { 858, "Wholesale and Retail Buyer" },
                    { 859, "Woodworker" },
                    { 860, "Woodworking Machine Setter" },
                    { 861, "Word Processor" },
                    { 862, "Typist" },
                    { 863, "Writer" },
                    { 864, "Authors " },
                    { 865, "Zoologist" },
                    { 866, "Wildlife Biologist" },
                    { 843, "Urban and Regional Planner" },
                    { 815, "Textile Cutting Machine Setter" },
                    { 842, "Upholsterer" },
                    { 840, "Pruner" },
                    { 817, "Therapist" },
                    { 818, "Tile and Marble Setter" },
                    { 819, "Timing Device Assembler" },
                    { 820, "Adjuster" },
                    { 821, "Tire Builder" },
                    { 822, "Tire Repairer" },
                    { 823, "Changer" },
                    { 824, "Title Examiner" },
                    { 825, "Tool Grinder" },
                    { 826, "Tool and Die Maker" },
                    { 827, "Tour Guide" },
                    { 828, "Escort" },
                    { 829, "Traffic Technician" },
                    { 830, "Training and Development Manager" },
                    { 831, "Training and Development Specialist" },
                    { 832, "Transit and Railroad Police" },
                    { 833, "Transportation Attendant" },
                    { 834, "Transportation Inspector" },
                    { 835, "Transportation Security Screener" },
                    { 836, "Transportation Worker" },
                    { 837, "Travel Agent" },
                    { 838, "Travel Guide" },
                    { 839, "Tree Trimmer" },
                    { 841, "Umpire" },
                    { 761, "Signal and Track Switch Repairer" },
                    { 760, "Shoe and Leather Worker" },
                    { 759, "Shoe Machine Operator" },
                    { 681, "Prosthodontist" },
                    { 682, "Protective Service Occupation" },
                    { 683, "Protective Service Worker" },
                    { 684, "Psychiatric Aide" },
                    { 685, "Psychiatric Technician" },
                    { 686, "Psychiatrist" },
                    { 687, "Psychologist" },
                    { 688, "Psychology Teacher" },
                    { 689, "Public Address System and Other Announcer" },
                    { 690, "Public Relations Specialist" },
                    { 691, "Public Relation" },
                    { 692, "Fundraising Manager" },
                    { 693, "Pump Operator" },
                    { 694, "Purchasing Manager" },
                    { 695, "Radiation Therapist" },
                    { 696, "Radio Operator" },
                    { 697, "Radio and Television Announcer" },
                    { 698, "Radiologic Technologist" },
                    { 699, "Rail Car Repairer" },
                    { 700, "Rail Transportation Worker" },
                    { 701, "Rail Yard Engineer" },
                    { 702, "Rail-Track Laying and Maintenance Equipment Operator" },
                    { 703, "Railroad Brake" },
                    { 680, "Property" },
                    { 704, "Railroad Conductor" },
                    { 679, "Copy Marker" },
                    { 677, "Production" },
                    { 654, "Postal Service Clerk" },
                    { 655, "Postal Service Mail Carrier" },
                    { 656, "Postal Service Mail Sorter" },
                    { 657, "Postmaster" },
                    { 658, "Mail Superintendent" },
                    { 659, "Postsecondary Teacher" },
                    { 660, "Pourer" },
                    { 661, "Caster" },
                    { 662, "Power Distributor" },
                    { 663, "Power Plant Operator" },
                    { 664, "Precision Instrument and Equipment Repairer" },
                    { 665, "Prepress Technician" },
                    { 666, "Preschool Teacher" },
                    { 667, "Presser" },
                    { 668, "Print Binding and Finishing Worker" },
                    { 669, "Printing Press Operator" },
                    { 435, "Inspector" },
                    { 671, "Probation Officer" },
                    { 672, "Correctional Treatment Specialist" },
                    { 673, "Procurement Clerk" },
                    { 674, "Producer" },
                    { 675, "Production Occupation" },
                    { 676, "Production Worker" },
                    { 678, "Proofreader" },
                    { 705, "Yardmaster" },
                    { 706, "Real Estate Broker" },
                    { 707, "Real Estate Sales Agent" },
                    { 736, "Marine Oiler" },
                    { 737, "Sales Engineer" },
                    { 738, "Sales Manager" },
                    { 739, "Sales Representative" },
                    { 740, "Sawing Machine Setter" },
                    { 741, "Secondary School Teacher" },
                    { 742, "Secretary" },
                    { 743, "Administrative Assistant" },
                    { 744, "Security Guard" },
                    { 745, "Security and Fire Alarm Systems Installer" },
                    { 746, "Segmental Paver" },
                    { 747, "Self-Enrichment Education Teacher" },
                    { 748, "Semiconductor Processor" },
                    { 749, "Septic Tank Servicer" },
                    { 750, "Sewer Pipe Cleaner" },
                    { 751, "Service Unit Operator" },
                    { 752, "Set and Exhibit Designer" },
                    { 753, "Sewer" },
                    { 754, "Sewing Machine Operator" },
                    { 755, "Shampooer" },
                    { 756, "Sheet Metal Worker" },
                    { 757, "Ship Engineer" },
                    { 758, "Shipping" },
                    { 735, "Sailor" },
                    { 734, "Roustabout" },
                    { 733, "Rotary Drill Operator" },
                    { 732, "Roofer" },
                    { 708, "Receptionist" },
                    { 709, "Information Clerk" },
                    { 710, "Recreation Worker" },
                    { 711, "Recreation and Fitness Studies Teacher" },
                    { 712, "Recreational Therapist" },
                    { 713, "Recreational Vehicle Service Technician" },
                    { 714, "Refractory Materials Repairer" },
                    { 715, "Refuse and Recyclable Material Collector" },
                    { 716, "Registered Nurse" },
                    { 717, "Rehabilitation Counselor" },
                    { 718, "Reinforcing Iron and Rebar Worker" },
                    { 652, "Political Science Teacher" },
                    { 719, "Religious Worker" },
                    { 721, "Correspondent" },
                    { 722, "Reservation and Transportation Ticket Agent" },
                    { 723, "Travel Clerk" },
                    { 724, "Residential Advisor" },
                    { 725, "Respiratory Therapist" },
                    { 726, "Respiratory Therapy Technician" },
                    { 727, "Retail Salesperson" },
                    { 728, "Rigger" },
                    { 729, "Rock Splitter" },
                    { 730, "Rolling Machine Setter" },
                    { 731, "Roof Bolter" },
                    { 720, "Reporter" },
                    { 434, "Information and Record Clerk" },
                    { 627, "Pharmacist" },
                    { 432, "Industrial-Organizational Psychologist" },
                    { 137, "Chiropractor" },
                    { 138, "Choreographer" },
                    { 139, "Civil Engineering Technician" },
                    { 140, "Civil Engineer" },
                    { 141, "Claims Adjuster" },
                    { 142, "Cleaners of Vehicle" },
                    { 143, "Equipment" },
                    { 144, "Cleaning" },
                    { 145, "Clergy" },
                    { 146, "Clinical" },
                    { 147, "Coache" },
                    { 148, "Scout" },
                    { 149, "Coating" },
                    { 150, "Coil Winder" },
                    { 151, "Coin" },
                    { 152, "Combined Food Preparation and Serving Worker" },
                    { 153, "Commercial Diver" },
                    { 154, "Commercial Pilot" },
                    { 155, "Commercial and Industrial Designer" },
                    { 156, "Communications Equipment Operator" },
                    { 157, "Communications Teacher" },
                    { 158, "Community and Social Service Specialist" },
                    { 159, "Community and Social Service Occupation" },
                    { 136, "Childcare Worker" },
                    { 160, "Compensation and Benefits Manager" },
                    { 135, "Child" },
                    { 133, "Chemist" },
                    { 110, "Cabinetmaker" },
                    { 111, "Bench Carpenter" },
                    { 112, "Camera Operator" },
                    { 113, "Camera and Photographic Equipment Repairer" },
                    { 114, "Captain" },
                    { 115, "Cardiovascular Technologist" },
                    { 116, "Technician" },
                    { 117, "Career/Technical Education Teacher" },
                    { 118, "Cargo and Freight Agent" },
                    { 119, "Carpenter" },
                    { 120, "Carpet Installer" },
                    { 121, "Cartographer" },
                    { 122, "Photogrammetrist" },
                    { 123, "Cashier" },
                    { 124, "Cement Mason" },
                    { 125, "Concrete Finisher" },
                    { 126, "Chef" },
                    { 127, "Head Cook" },
                    { 128, "Chemical Engineer" },
                    { 129, "Chemical Equipment Operator" },
                    { 130, "Chemical Plant and System Operator" },
                    { 131, "Chemical Technician" },
                    { 132, "Chemistry Teacher" },
                    { 134, "Chief Executive" },
                    { 161, "Compensation" },
                    { 162, "Compliance Officer" },
                    { 163, "Computer Hardware Engineer" },
                    { 192, "Costume Attendant" },
                    { 193, "Counselor" },
                    { 194, "Counter Attendant" },
                    { 195, "Counter and Rental Clerk" },
                    { 196, "Courier" },
                    { 197, "Messenger" },
                    { 198, "Court Reporter" },
                    { 199, "Court" },
                    { 200, "Craft Artist" },
                    { 201, "Crane and Tower Operator" },
                    { 202, "Credit Analyst" },
                    { 203, "Credit Authorizer" },
                    { 204, "Credit Counselor" },
                    { 205, "Criminal Justice and Law Enforcement Teacher" },
                    { 206, "Crossing Guard" },
                    { 207, "Crushing" },
                    { 208, "Curator" },
                    { 209, "Customer Service Representative" },
                    { 210, "Cutter" },
                    { 211, "Trimmer" },
                    { 212, "Cutting and Slicing Machine Setter" },
                    { 213, "Cutting" },
                    { 214, "Dancer" },
                    { 191, "Cost Estimator" },
                    { 190, "Correspondence Clerk" },
                    { 189, "Jailer" },
                    { 188, "Correctional Officer" },
                    { 164, "Computer Numerically Controlled Machine Tool Programmer" },
                    { 165, "Computer Occupation" },
                    { 166, "Computer Operator" },
                    { 167, "Computer Programmer" },
                    { 168, "Computer Science Teacher" },
                    { 169, "Computer Support Specialist" },
                    { 170, "Computer Systems Analyst" },
                    { 171, "Computer and Information Research Scientist" },
                    { 172, "Computer and Information Systems Manager" },
                    { 173, "Computer and Mathematical Occupation" },
                    { 174, "Computer" },
                    { 109, "Purchasing Agent" },
                    { 175, "Computer-Controlled Machine Tool Operator" },
                    { 177, "Conservation Scientist" },
                    { 178, "Construction Laborer" },
                    { 179, "Construction Manager" },
                    { 180, "Construction and Building Inspector" },
                    { 181, "Construction and Extraction Occupation" },
                    { 182, "Construction and Related Worker" },
                    { 183, "Continuous Mining Machine Operator" },
                    { 184, "Control and Valve Installer" },
                    { 185, "Conveyor Operator" },
                    { 186, "Cook" },
                    { 187, "Cooling and Freezing Equipment Operator" },
                    { 176, "Concierge" },
                    { 215, "Data Entry Keyer" },
                    { 108, "Buyer" },
                    { 106, "Butcher" },
                    { 28, "Airfield Operations Specialist" },
                    { 29, "Airline Pilot" },
                    { 30, "All Occupation" },
                    { 31, "Ambulance Driver" },
                    { 32, "Attendant" },
                    { 33, "Amusement and Recreation Attendant" },
                    { 34, "Anesthesiologist" },
                    { 35, "Animal Breeder" },
                    { 36, "Animal Control Worker" },
                    { 37, "Animal Scientist" },
                    { 38, "Animal Trainer" },
                    { 39, "Anthropologist" },
                    { 40, "Archeologist" },
                    { 41, "Anthropology and Archeology Teacher" },
                    { 42, "Appraiser" },
                    { 43, "Assessors of Real Estate" },
                    { 44, "Arbitrator" },
                    { 45, "Architect" },
                    { 46, "Architectural and Civil Drafter" },
                    { 47, "Architectural and Engineering Manager" },
                    { 48, "Architecture Teacher" },
                    { 49, "Architecture and Engineering Occupation" },
                    { 50, "Archivist" },
                    { 27, "Aircraft Structure" },
                    { 51, "Area" },
                    { 26, "Service Technician" },
                    { 24, "Aircraft Cargo Handling Supervisor" },
                    { 1, "Accountant" },
                    { 2, "Auditor" },
                    { 3, "Actor" },
                    { 4, "Actuary" },
                    { 433, "Information Security Analyst" },
                    { 6, "Tender" },
                    { 7, "Administrative Law Judge" },
                    { 8, "Administrative Services Manager" },
                    { 9, "Adult Basic and Secondary Education and Literacy Teacher" },
                    { 10, "Instructor" },
                    { 11, "Advertising Sales Agent" },
                    { 12, "Advertising and Promotions Manager" },
                    { 13, "Aerospace Engineering and Operations Technician" },
                    { 14, "Aerospace Engineer" },
                    { 15, "Agent" },
                    { 16, "Business Managers of Artist" },
                    { 17, "Agricultural Engineer" },
                    { 18, "Agricultural Equipment Operator" },
                    { 19, "Agricultural Inspector" },
                    { 20, "Agricultural Sciences Teacher" },
                    { 21, "Agricultural Worker" },
                    { 22, "Agricultural and Food Science Technician" },
                    { 23, "Air Traffic Controller" },
                    { 25, "Aircraft Mechanic" },
                    { 52, "Art Director" },
                    { 53, "Artist" },
                    { 54, "Assembler" },
                    { 83, "Biological Science Teacher" },
                    { 84, "Biological Scientist" },
                    { 85, "Biological Technician" },
                    { 86, "Biomedical Engineer" },
                    { 87, "Boilermaker" },
                    { 88, "Bookkeeping" },
                    { 89, "Brickmason" },
                    { 90, "Blockmason" },
                    { 91, "Bridge and Lock Tender" },
                    { 92, "Broadcast News Analyst" },
                    { 93, "Broadcast Technician" },
                    { 94, "Brokerage Clerk" },
                    { 95, "Budget Analyst" },
                    { 96, "Building Cleaning Worker" },
                    { 97, "Building and Grounds Cleaning and Maintenance Occupation" },
                    { 98, "Bus Driver" },
                    { 99, "Bu" },
                    { 100, "Truck Mechanic" },
                    { 101, "Diesel Engine Specialist" },
                    { 102, "Business Operations Specialist" },
                    { 103, "Business Teacher" },
                    { 104, "Busines" },
                    { 105, "Financial Operations Occupation" },
                    { 82, "Biophysicist" },
                    { 81, "Biochemist" },
                    { 80, "Billing and Posting Clerk" },
                    { 79, "Bill and Account Collector" },
                    { 55, "Fabricator" },
                    { 56, "Astronomer" },
                    { 57, "Athlete" },
                    { 58, "Sports Competitor" },
                    { 59, "Athletic Trainer" },
                    { 60, "Atmospheric and Space Scientist" },
                    { 61, "Atmospheric" },
                    { 62, "Audio and Video Equipment Technician" },
                    { 63, "Audio-Visual and Multimedia Collections Specialist" },
                    { 64, "Audiologist" },
                    { 65, "Automotive Body and Related Repairer" },
                    { 107, "Meat Cutter" },
                    { 66, "Automotive Glass Installer" },
                    { 68, "Automotive Service Technician" },
                    { 69, "Mechanic" },
                    { 70, "Automotive and Watercraft Service Attendant" },
                    { 71, "Avionics Technicians " },
                    { 72, "Baggage Porter" },
                    { 73, "Bellhop" },
                    { 74, "Bailiff" },
                    { 75, "Baker" },
                    { 76, "Barber" },
                    { 77, "Bartender" },
                    { 78, "Bicycle Repairer" },
                    { 67, "Repairer" },
                    { 216, "Database Administrator" },
                    { 5, "Adhesive Bonding Machine Operator" },
                    { 218, "Product Promoter" },
                    { 354, "Food Scientist" },
                    { 355, "Technologist" },
                    { 356, "Food Server" },
                    { 357, "Food Service Manager" },
                    { 358, "Food and Tobacco Roasting" },
                    { 359, "Foreign Language and Literature Teacher" },
                    { 360, "Forensic Science Technician" },
                    { 361, "Forest Fire Inspector" },
                    { 362, "Prevention Specialist" },
                    { 363, "Forest and Conservation Technician" },
                    { 364, "Forest and Conservation Worker" },
                    { 365, "Forester" },
                    { 366, "Forestry and Conservation Science Teacher" },
                    { 367, "Forging Machine Setter" },
                    { 368, "Foundry Mold and Coremaker" },
                    { 369, "Funeral Attendant" },
                    { 370, "Funeral Service Manager" },
                    { 371, "Furniture Finisher" },
                    { 372, "Gaming Cage Worker" },
                    { 373, "Gaming Change Person" },
                    { 374, "Booth Cashier" },
                    { 375, "Gaming Dealer" },
                    { 376, "Gaming Manager" },
                    { 353, "Food Preparation and Serving Related Worker" },
                    { 377, "Gaming Service Worker" },
                    { 352, "Food Preparation and Serving Related Occupation" },
                    { 350, "Food Cooking Machine Operator" },
                    { 327, "First-Line Supervisors of Helper" },
                    { 328, "First-Line Supervisors of Housekeeping and Janitorial Worker" },
                    { 329, "First-Line Supervisors of Landscaping" },
                    { 330, "First-Line Supervisors of Mechanic" },
                    { 331, "First-Line Supervisors of Non-Retail Sales Worker" },
                    { 332, "First-Line Supervisors of Office and Administrative Support Worker" },
                    { 333, "First-Line Supervisors of Personal Service Worker" },
                    { 334, "First-Line Supervisors of Police and Detective" },
                    { 335, "First-Line Supervisors of Production and Operating Worker" },
                    { 336, "First-Line Supervisors of Protective Service Worker" },
                    { 337, "First-Line Supervisors of Retail Sales Worker" },
                    { 338, "First-Line Supervisors of Transportation and Material-Moving Machine and Vehicle Operator" },
                    { 339, "Fish and Game Warden" },
                    { 340, "Fisher" },
                    { 341, "Related Fishing Worker" },
                    { 342, "Fitness Trainer" },
                    { 343, "Aerobics Instructor" },
                    { 344, "Flight Attendant" },
                    { 345, "Floor Layer" },
                    { 346, "Floor Sander" },
                    { 347, "Finisher" },
                    { 348, "Floral Designer" },
                    { 349, "Food Batchmaker" },
                    { 351, "Food Preparation Worker" },
                    { 378, "Gaming Supervisor" },
                    { 379, "Gaming Surveillance Officer" },
                    { 380, "Gaming Investigator" },
                    { 409, "Healthcare Support Occupation" },
                    { 410, "Healthcare Support Worker" },
                    { 411, "Heat Treating Equipment Setter" },
                    { 412, "Heavy and Tractor-Trailer Truck Driver" },
                    { 413, "Highway Maintenance Worker" },
                    { 414, "Historian" },
                    { 415, "History Teacher" },
                    { 416, "Hoist and Winch Operator" },
                    { 417, "Home Appliance Repairer" },
                    { 418, "Home Economics Teacher" },
                    { 419, "Home Health Aide" },
                    { 420, "Host" },
                    { 421, "Hostess" },
                    { 422, "Human Resources Assistant" },
                    { 423, "Human Resources Manager" },
                    { 424, "Hunter" },
                    { 425, "Trapper" },
                    { 426, "Hydrologist" },
                    { 427, "Industrial Engineering Technician" },
                    { 428, "Industrial Engineer" },
                    { 429, "Industrial Machinery Mechanic" },
                    { 431, "Industrial Truck and Tractor Operator" },
                    { 217, "Demonstrator" },
                    { 408, "Healthcare Social Worker" },
                    { 407, "Technical Worker" },
                    { 406, "Technical Occupation" },
                    { 405, "Healthcare Practitioner" },
                    { 381, "Gaming and Sports Book Writer" },
                    { 382, "Runner" },
                    { 383, "Gas Compressor and Gas Pumping Station Operator" },
                    { 384, "Gas Plant Operator" },
                    { 385, "General and Operations Manager" },
                    { 386, "Geographer" },
                    { 387, "Geography Teacher" },
                    { 388, "Geological and Petroleum Technician" },
                    { 389, "Geoscientist" },
                    { 390, "Glazier" },
                    { 391, "Grader" },
                    { 326, "First-Line Supervisors of Food Preparation and Serving Worker" },
                    { 392, "Sorter" },
                    { 394, "Graphic Designer" },
                    { 395, "Grinding and Polishing Worker" },
                    { 396, "Grinding" },
                    { 397, "Grounds Maintenance Worker" },
                    { 398, "Hairdresser" },
                    { 399, "Hazardous Materials Removal Worker" },
                    { 400, "Health Diagnosing and Treating Practitioner" },
                    { 401, "Health Educator" },
                    { 402, "Health Specialties Teacher" },
                    { 403, "Health Technologist" },
                    { 404, "Health and Safety Engineer" },
                    { 393, "Graduate Teaching Assistant" },
                    { 325, "First-Line Supervisors of Fire Fighting and Prevention Worker" },
                    { 430, "Industrial Production Manager" },
                    { 323, "First-Line Supervisors of Correctional Officer" },
                    { 245, "Economist" },
                    { 246, "Editor" },
                    { 247, "Education Administrator" },
                    { 248, "Education Teacher" },
                    { 249, "Education" },
                    { 250, "Educational" },
                    { 251, "Electric Motor" },
                    { 252, "Electrical Engineer" },
                    { 253, "Electrical Power-Line Installer" },
                    { 254, "Electrical and Electronic Equipment Assembler" },
                    { 255, "Electrical and Electronics Drafter" },
                    { 256, "Electrical and Electronics Engineering Technician" },
                    { 257, "Electrical and Electronics Installer" },
                    { 258, "Electrical and Electronics Repairer" },
                    { 259, "Electrician" },
                    { 260, "Electro-Mechanical Technician" },
                    { 261, "Electromechanical Equipment Assembler" },
                    { 262, "Electronic Equipment Installer" },
                    { 263, "Electronic Home Entertainment Equipment Installer" },
                    { 264, "Electronics Engineer" },
                    { 265, "Elementary School Teacher" },
                    { 266, "Elevator Installer" },
                    { 267, "Eligibility Interviewer" },
                    { 244, "Economics Teacher" },
                    { 268, "Embalmer" },
                    { 243, "Earth Driller" },
                    { 241, "Driver/Sales Worker" },
                    { 220, "Dental Hygienist" },
                    { 324, "First-Line Supervisors of Farming" },
                    { 221, "Dental Laboratory Technician" },
                    { 222, "Dentist" },
                    { 223, "Derrick Operator" },
                    { 224, "Designer" },
                    { 225, "Desktop Publisher" },
                    { 226, "Detective" },
                    { 227, "Criminal Investigator" },
                    { 228, "Diagnostic Medical Sonographer" },
                    { 229, "Dietetic Technician" },
                    { 230, "Dietitian" },
                    { 231, "Nutritionist" },
                    { 232, "Dining Room and Cafeteria Attendant" },
                    { 233, "Bartender Helper" },
                    { 234, "Director" },
                    { 235, "Dishwasher" },
                    { 236, "Dispatcher" },
                    { 237, "Door-to-Door Sales Worker" },
                    { 238, "Drafter" },
                    { 239, "Dredge Operator" },
                    { 219, "Dental Assistant" },
                    { 240, "Drilling and Boring Machine Tool Setter" },
                    { 242, "Drywall and Ceiling Tile Installers " },
                    { 269, "Emergency Management Director" },
                    { 270, "Emergency Medical Technician" },
                    { 271, "Paramedic" },
                    { 300, "Faller" },
                    { 301, "Family and General Practitioner" },
                    { 302, "Farm Equipment Mechanic" },
                    { 303, "Farm Labor Contractor" },
                    { 304, "Farm and Home Management Advisor" },
                    { 305, "Farmer" },
                    { 306, "Farming" },
                    { 307, "Farmworker" },
                    { 308, "Laborer" },
                    { 309, "Fashion Designer" },
                    { 310, "Fence Erector" },
                    { 311, "Fiberglass Laminator" },
                    { 312, "File Clerk" },
                    { 313, "Film and Video Editor" },
                    { 314, "Financial Analyst" },
                    { 315, "Financial Examiner" },
                    { 316, "Financial Manager" },
                    { 317, "Financial Specialist" },
                    { 318, "Fine Artist" },
                    { 319, "Fire Inspector" },
                    { 320, "Investigator" },
                    { 321, "Firefighter" },
                    { 322, "First-Line Supervisors of Construction Trade" },
                    { 299, "Fabric and Apparel Patternmaker" },
                    { 298, "Fabric Mender" },
                    { 297, "Extruding" },
                    { 296, "Extruding and Forming Machine Setter" },
                    { 272, "Engine and Other Machine Assembler" },
                    { 273, "Engineering Teacher" },
                    { 274, "Engineering Technician" },
                    { 275, "Engineer" },
                    { 276, "English Language and Literature Teacher" },
                    { 277, "Entertainer" },
                    { 278, "Performer" },
                    { 279, "Entertainment Attendant" },
                    { 280, "Related Worker" },
                    { 281, "Environmental Engineering Technician" },
                    { 282, "Environmental Engineer" },
                    { 283, "Environmental Science Teacher" },
                    { 285, "Environmental Scientist" },
                    { 286, "Specialist" },
                    { 287, "Epidemiologist" },
                    { 288, "Etcher" },
                    { 289, "Engraver" },
                    { 290, "Excavating and Loading Machine and Dragline Operator" },
                    { 291, "Executive Secretarie" },
                    { 292, "Executive Administrative Assistant" },
                    { 293, "Explosives Worker" },
                    { 294, "Extraction Worker" },
                    { 295, "Extruding and Drawing Machine Setter" },
                    { 284, "Environmental Science and Protection Technician" }
                });

            migrationBuilder.InsertData(
                table: "personality",
                columns: new[] { "id", "personality_name" },
                values: new object[,]
                {
                    { 4, "I'd perfer not to say" },
                    { 3, "Somewhere in between" },
                    { 2, "Introvert" },
                    { 1, "Extrovert" }
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
                    { 270, "Associated Churches of Christ" },
                    { 271, "Elim" },
                    { 272, "Revival Centres" },
                    { 273, "Commonwealth Covenant Church" },
                    { 277, "Christian Revival Crusade" },
                    { 275, "Chinese Christian" },
                    { 276, "Christian Outreach" },
                    { 269, "Born Again Christian" },
                    { 274, "Assyrian Orthodox" },
                    { 268, "Shiite Islam" },
                    { 264, "Plymouth Brethren" },
                    { 266, "Reformed Churches" },
                    { 265, "Ratana" },
                    { 278, "Cook Island Congregational" },
                    { 263, "Christian Science" },
                    { 262, "Bible Baptist" },
                    { 261, "Kirati" },
                    { 260, "SaioZione" },
                    { 259, "Denomination not specified" },
                    { 258, "Orientalists' Cults" },
                    { 257, "Shaman" },
                    { 267, "Ringatu" },
                    { 279, "Druid" },
                    { 283, "Independent Evangelical Churches" },
                    { 281, "Fundamentalist" },
                    { 301, "United Pentecostal" },
                    { 300, "Unification Church" },
                    { 299, "Tongan Methodist" },
                    { 205, "International Church of the Foursquare Gospel" },
                    { 298, "Theism" },
                    { 297, "Tenrikyo" },
                    { 296, "Sufi" },
                    { 295, "Samoan Congregational" },
                    { 294, "Religious Society of Friends" },
                    { 293, "Reformed Baptist" },
                    { 292, "Other Church of Christ" },
                    { 291, "Open Brethren" },
                    { 290, "New life centres" },
                    { 289, "Metropolitan" },
                    { 288, "Mäori Religion" },
                    { 287, "Mahikari" },
                    { 286, "Liberal Catholic" },
                    { 285, "Korean Christian" },
                    { 284, "Independent Pentecostal" },
                    { 256, "Historics" },
                    { 282, "Independent Baptist" },
                    { 280, "Ecumenical" },
                    { 255, "Ethnic Churches" },
                    { 251, "Baboojee" },
                    { 253, "Rabidass" },
                    { 227, "ConfucianismTaoism and Other Traditional Chinese" },
                    { 226, "Non-denominational Christian Churches" },
                    { 225, "Neuapostolische Kirche" },
                    { 224, "All Gospel Church" },
                    { 223, "Charismatic Evangelical Church" },
                    { 222, "Word of Faith" },
                    { 221, "Sunni Muslims" },
                    { 220, "Society for Krishna Consciousness" },
                    { 219, "Karaite" },
                    { 218, "Evangelical Reformists" },
                    { 217, "Evangelical Lutherans" },
                    { 216, "Church of Scientology" },
                    { 215, "Balts Believers" },
                    { 214, "Protestant Lutheran" },
                    { 213, "Protestant Reformed" },
                    { 212, "No Afiliation" },
                    { 211, "Bengali" },
                    { 210, "Arya Samajist" },
                    { 209, "Te koaua" },
                    { 208, "Kempsville Presbyterian Church" },
                    { 207, "All Nations Baptist" },
                    { 228, "Tribal" },
                    { 229, "Ahir" },
                    { 230, "Ahmadhya" },
                    { 231, "Aryan" },
                    { 252, "Mohamedan" },
                    { 302, "Wiccan" },
                    { 250, "Other Chinese" },
                    { 249, "Peniel Tabernacle" },
                    { 248, "La Voix de la Delivrance" },
                    { 206, "Te Ran" },
                    { 247, "Eglise Chrétienne" },
                    { 246, "Other Muslims" },
                    { 245, "Sanatanist" },
                    { 244, "Other Hindu" }
                });

            migrationBuilder.InsertData(
                table: "religion",
                columns: new[] { "id", "religion_name" },
                values: new object[,]
                {
                    { 254, "Telegu Speaking" },
                    { 243, "Vedic" },
                    { 241, "Telegu and Telegu Hindu" },
                    { 240, "Témoin de Jehovah" },
                    { 239, "Tamil and Tamil Hindu" },
                    { 238, "Rajput" },
                    { 237, "Puranic" },
                    { 236, "Mission Salut et Guerison" },
                    { 235, "Marathi & Marathi Hindu" },
                    { 234, "Kabir Panthis" },
                    { 233, "Christian Tamil" },
                    { 232, "Chinese" },
                    { 242, "Vaish" },
                    { 303, "Yoga" },
                    { 361, "African Traditional Belief" },
                    { 305, "Hauhau" },
                    { 378, "Other Congregational Churches" },
                    { 377, "Other Charismatic Churches" },
                    { 376, "Other Assemblies" },
                    { 375, "Other African Apostolic Churches" },
                    { 374, "Pinkster Protestante Kerk" },
                    { 373, "Nederduits Hervormde Kerk" },
                    { 372, "NA: Institution" },
                    { 371, "International Fellowship of Christian Church" },
                    { 370, "Bandla Lama Nazaretha" },
                    { 369, "Afrikaanse Protestante Kerk" },
                    { 368, "Other Faiths" },
                    { 367, "Ibandlalama Nazaretha" },
                    { 366, "Zion Christian Church" },
                    { 365, "Other Zionist Churches" },
                    { 364, "Other African Independent Churches" },
                    { 363, "Ethiopian Churches" },
                    { 362, "Apostolic Faith Mission of SA" },
                    { 360, "Baptists Fraternity Union" },
                    { 359, "Byzantine Catholic Church" },
                    { 358, "Reformed Christian" },
                    { 357, "Fraternity Church" },
                    { 379, "Other Pentecostal Churches" },
                    { 380, "Other Presbyterian Churches" },
                    { 381, "St. Engenas Zion Christian Church" },
                    { 382, "St. John's Apostolic Church" },
                    { 403, "Hoa hao - Hoa Hao" },
                    { 204, "Latter Day Saints (Mormon)" },
                    { 402, "Cao daii - Cao Dai" },
                    { 401, "Hoi giao - Muslim" },
                    { 400, "Tin lanh - Protestant" },
                    { 399, "Cong giao - Catholic" },
                    { 398, "Phat giao - Buddhist" },
                    { 397, "Church of Tuvalu" },
                    { 396, "New Testament Church" },
                    { 395, "Ekalesia Kelisiano Tuvalu" },
                    { 356, "Evangelic Methodist Church" },
                    { 394, "Brethren Assembly" },
                    { 392, "Pentecostal Evangelical Full Gospel" },
                    { 391, "Orisha" },
                    { 390, "Constitutional Church of Tonga" },
                    { 389, "Tokaikolo Christian Church" },
                    { 388, "Free Wesleyan Church" },
                    { 387, "Free Church of Tonga" },
                    { 386, "Church of Tonga" },
                    { 385, "Protestant Evangelical" },
                    { 384, "Other Adventist Churches" },
                    { 383, "Full Gospel Church of God" },
                    { 393, "Presbyterian Congregational" },
                    { 304, "Zen Buddhist" },
                    { 355, "Evangelic of Augsburg Affiliation" },
                    { 353, "IslamJudaism" },
                    { 326, "Philippine Benevolent Missionaries Association" },
                    { 325, "Missionary Baptist Churches of the Philippines" },
                    { 324, "International Baptist Missionary Fellowship" },
                    { 323, "Iglesia Evangelista Methodista en Las Filipinas" },
                    { 322, "Iglesia ni Cristo" },
                    { 321, "Convention of the Philippine Baptist Church" },
                    { 320, "Aglipay" },
                    { 319, "Evangelical Christian" },
                    { 318, "None or Refused" },
                    { 317, "Modekngei" },
                    { 316, "Scheduled Castes" },
                    { 315, "QadianiAhmadi" },
                    { 314, "Non-Christian" },
                    { 313, "Australian Christian Church" },
                    { 312, "Uniting Church" },
                    { 311, "Ekalesia Niue" },
                    { 310, "Object" },
                    { 309, "Mäori Christian" },
                    { 308, "Apostolic Church of New Zealand" },
                    { 307, "Brethren Exclusive" },
                    { 306, "Reformat" },
                    { 327, "United Church of Christ" },
                    { 328, "Other Baptist Churches" },
                    { 329, "Episcopal" },
                    { 330, "Southern Baptist" },
                    { 352, "Eastern religion" },
                    { 351, "Non-Apostolic" },
                    { 350, "Maná" },
                    { 349, "Community Church" },
                    { 348, "Aoga Tusi Paia" },
                    { 347, "Peace Chapel" },
                    { 346, "Samoa Evangelism" },
                    { 345, "Voice of Christ" },
                    { 344, "CCCJS" },
                    { 343, "Worship Centre" },
                    { 354, "Buddhism Sikh" },
                    { 342, "Mosaic" },
                    { 340, "Evangelic Synodal Presbyterian" },
                    { 339, "Christian of Old Rite" },
                    { 338, "Daesoonjillihoi" },
                    { 337, "Taejong-gyo" },
                    { 336, "Ch'ondo-gyo" },
                    { 335, "Won Buddhist" },
                    { 334, "Didn't answer" },
                    { 333, "Evangelic Augustan Confession" },
                    { 332, "Other Methodist Churches" },
                    { 331, "United Methodist Church" },
                    { 341, "Christian by Gospel" },
                    { 203, "African Instituted Churches" },
                    { 94, "God is Love" },
                    { 201, "Other Church of God" },
                    { 72, "New Apostolic" },
                    { 71, "Mennonite" },
                    { 70, "Greek Orthodox" },
                    { 69, "Greek Oriental" },
                    { 68, "Church of England" },
                    { 67, "Christengmeinschaft" },
                    { 66, "Unknown" },
                    { 65, "Oriental Christian" },
                    { 64, "Zoroastrianism" },
                    { 63, "Theism, nec" },
                    { 62, "Oriental Orthodox" },
                    { 61, "Assyrian Apostolic" },
                    { 60, "Secular Beliefs" },
                    { 59, "Australian Aboriginal Traditional Religion" },
                    { 58, "Nature and earth based religions" },
                    { 57, "Japanese Religions" },
                    { 56, "Presbyterian and Reformed" },
                    { 55, "Chinese Religions" },
                    { 54, "Christian nfd" },
                    { 53, "Jehovah's Witnesses" },
                    { 52, "Other Protestant" },
                    { 73, "Old Catholic Church" },
                    { 51, "United Church" },
                    { 74, "Shinto" },
                    { 76, "Christian Community" },
                    { 98, "Roman Apostolic Catholic" },
                    { 97, "Other Traditional Evangelical" },
                    { 202, "Church of God in Jamaica" },
                    { 95, "Orthodox Catholic" },
                    { 93, "Espiritia" },
                    { 92, "Christian Congregation of Brazil" },
                    { 91, "Candomble" },
                    { 90, "Brasilian Apostolic Catholic" },
                    { 89, "Badimo" },
                    { 88, "Ethiopian Orthodox" },
                    { 87, "Non-denominational" },
                    { 86, "African Methodist Episcopal Church" },
                    { 85, "Wesleyan" },
                    { 84, "Nazarene" },
                    { 83, "Christian" },
                    { 82, "Greek Church" },
                    { 81, "None" },
                    { 80, "Other Non-Christians" },
                    { 79, "Mormon" },
                    { 78, "Assembly of God" },
                    { 77, "Free Christian Community" },
                    { 75, "Unification" },
                    { 50, "Sikh" },
                    { 49, "Lutheran" },
                    { 48, "Latter Day Saints" },
                    { 21, "Presbyterian" },
                    { 20, "Pentecostal" },
                    { 19, "Methodist" },
                    { 18, "Jewish" },
                    { 17, "Jehovah Witness" },
                    { 16, "Hindu" },
                    { 15, "Church of God" },
                    { 14, "Brethren" },
                    { 13, "Baptist" },
                    { 12, "Anglican" },
                    { 11, "Not Stated" },
                    { 10, "Believers without denomination" },
                    { 9, "Bektashism" },
                    { 8, "Refused to answer" },
                    { 7, "Other Christians" },
                    { 6, "Other" },
                    { 5, "Orthodox" },
                    { 4, "Muslim" },
                    { 3, "Evangelical" },
                    { 2, "Catholic" },
                    { 1, "Atheist" },
                    { 22, "Rastafarian" },
                    { 23, "Roman Catholic" },
                    { 24, "Seventh Day Adventist" },
                    { 25, "Other Religions" },
                    { 47, "Judaism" },
                    { 46, "Eastern Orthodox" },
                    { 45, "Druze" },
                    { 44, "Church of Christ" },
                    { 43, "Buddhist" },
                    { 42, "Other Religions and Persuasions" },
                    { 41, "Protestant" },
                    { 40, "Adventist" },
                    { 39, "Shar-fadinian" },
                    { 38, "Molokai" },
                    { 99, "Umbanda" },
                    { 37, "Yeshiva's witness" },
                    { 35, "Armenian Orthodox" },
                    { 34, "Armenian Apostolic" },
                    { 33, "Not Declared" },
                    { 32, "Spiritualist" },
                    { 31, "Salvation Army" },
                    { 30, "Moravian" },
                    { 29, "Islam " },
                    { 28, "Baha'i" },
                    { 27, "Not Specified" },
                    { 26, "No Religion" },
                    { 36, "Pagan" },
                    { 100, "Universal of the Kingdom of God" },
                    { 96, "Other Evangelical Pentecostal" },
                    { 102, "Umbanda e Candomblé" },
                    { 174, "Czechoslovak Hussite Church" },
                    { 173, "Maronite church" },
                    { 172, "Armenian church" },
                    { 171, "Non-believers" },
                    { 170, "Greek Catholic" },
                    { 169, "Calvinist" },
                    { 168, "Oriental" },
                    { 167, "Harriste" },
                    { 166, "Celestial" },
                    { 165, "Holy Spirit" },
                    { 164, "Cook Islands Christian Church" },
                    { 163, "Apostolic" },
                    { 162, "No religion, Agnostic, Atheist" },
                    { 161, "Church of God nos" },
                    { 160, "Polish National Catholic Church" },
                    { 159, "Other Eastern religions" },
                    { 158, "Standard Church" },
                    { 101, "Messianica" },
                    { 156, "Canadian and American Reformed Church" },
                    { 155, "Canadian Reformed Church" },
                    { 154, "Christians, n.i.e." },
                    { 175, "Silesian Evangelical Church" },
                    { 176, "Other Evangelical Churches" },
                    { 177, "Hare Rama Hare Krishna" },
                    { 178, "Old Believers" },
                    { 200, "Revived" },
                    { 199, "Church of God of Prophecy" },
                    { 198, "Pantheism" },
                    { 197, "Lapsed Roman Catholic" },
                    { 196, "Church of Ireland" },
                    { 195, "Not Asked" },
                    { 194, "Confucian" },
                    { 193, "Christian Orthodox" },
                    { 192, "Islamic Congregation" },
                    { 191, "Other Lutheran Churches" },
                    { 153, "Brethren in Christ" },
                    { 190, "Free Church in Finland" },
                    { 188, "Full Gospel Church" },
                    { 187, "Congregational" },
                    { 186, "Christian Free Congregations" },
                    { 185, "Taara or Earth Believer" },
                    { 184, "Charismatic Episcopal Church" },
                    { 183, "Ukrainian Greek-Catholic Church" },
                    { 182, "Russian Catholic Orthodox Church" },
                    { 181, "Estonian Ancient Belief" },
                    { 180, "Church of Christian Fellowship" },
                    { 179, "Church of Charismatic Fellowship" },
                    { 189, "Other Apostolic Churches" },
                    { 152, "Apostolic Christian Church" },
                    { 157, "Hutterite" },
                    { 150, "Other Reformed Church" },
                    { 123, "Evangelical Free Church" },
                    { 122, "Dutch Reformed" },
                    { 151, "Ukrainian Catholic" },
                    { 120, "Coptic Orthodox" },
                    { 119, "Church of Nazarene" },
                    { 118, "Church of Jesus Christ of Latter-day Saints" },
                    { 117, "Christian Reformed Church" },
                    { 116, "Christian or Plymouth Brethren" },
                    { 115, "Christian and Mission Alliance" },
                    { 114, "Christian Congregational" },
                    { 113, "Christadelphian" },
                    { 112, "Charismatic Renewal" },
                    { 111, "Associated Gospel" },
                    { 110, "Antiochian Orthodox Christian" },
                    { 109, "Agnostic" },
                    { 108, "Aboriginal spirituality" },
                    { 107, "Traditional" },
                    { 106, "Animist" },
                    { 105, "Yiddish" },
                    { 104, "Armeno-Gregorian" },
                    { 103, "New Testament Church of God" },
                    { 124, "Evangelical Missionary Church" },
                    { 125, "Free Methodists" },
                    { 121, "Doukhobors" },
                    { 127, "Humanist" },
                    { 149, "Other Orthodox Churches" },
                    { 148, "Other Catholic" },
                    { 147, "Zoroastrian" },
                    { 146, "Worldwide Church of God" },
                    { 145, "Vineyard Christian Fellowship" },
                    { 126, "Gnostic" },
                    { 143, "Unitarian" },
                    { 142, "Ukrainian Orthodox" },
                    { 141, "Taoist" },
                    { 140, "Swedenborgian (New Church)" },
                    { 139, "Serbian Orthodox" },
                    { 144, "Unity-New Thought-Pantheist" },
                    { 137, "Satanist" },
                    { 138, "Scientology" },
                    { 128, "Interdenominational" },
                    { 130, "Mission de l'Esprit Saint" },
                    { 131, "New Age" },
                    { 129, "Jains" },
                    { 133, "Quakers" },
                    { 134, "Reorganized Church of Latter-day Saints" },
                    { 135, "Romanian Orthodox" },
                    { 136, "Russian Orthodox" },
                    { 132, "Protestant nfd" }
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
                name: "UQ__children__0EABE7D4CB0DA211",
                table: "children",
                column: "children_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__drinking__9D7395480C67974E",
                table: "drinking",
                column: "drinking_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__educatio__24EB10605221BD69",
                table: "education_level",
                column: "education_level_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__eye_colo__03FE59862DD592D3",
                table: "eye_colour",
                column: "colour",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__gender__2FB51D2762C41EAC",
                table: "gender",
                column: "gender_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__hair_col__03FE5986728D5EDA",
                table: "hair_colour",
                column: "colour",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__here_to__4A9F60AB6011307E",
                table: "here_to",
                column: "here_to_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__interest__5D5CAFB66473CFDB",
                table: "interests",
                column: "interest_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__job_titl__E52A1BB393E7AA0D",
                table: "job_title",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__language__9CE82383F23A4EDA",
                table: "language",
                column: "language_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__personal__D7AAAD867FCCC886",
                table: "personality",
                column: "personality_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_preference_preference_sex_id",
                table: "preference",
                column: "preference_sex_id");

            migrationBuilder.CreateIndex(
                name: "UQ__preferen__DDDFBCA6CF40DF10",
                table: "preference_sex",
                column: "sex",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_refresh_token_user_id",
                table: "refresh_token",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "UQ__relation__A286B4ADFE7B04EF",
                table: "relationship",
                column: "relationship_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__religion__07872CE4E07542C6",
                table: "religion",
                column: "religion_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__role__783254B1BFB4EEAA",
                table: "role",
                column: "role_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__sexualit__BCE65079F396BF0D",
                table: "sexuality",
                column: "sexuality_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__smoking__0BDBB7468792F4F2",
                table: "smoking",
                column: "smoking_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__user__20C6DFF58727EEAC",
                table: "user",
                column: "email_address",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_role_id",
                table: "user",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_children_id",
                table: "user_info",
                column: "children_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_drinking_id",
                table: "user_info",
                column: "drinking_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_education_level_id",
                table: "user_info",
                column: "education_level_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_eye_colour_id",
                table: "user_info",
                column: "eye_colour_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_gender_id",
                table: "user_info",
                column: "gender_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_hair_colour_id",
                table: "user_info",
                column: "hair_colour_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_here_to_id",
                table: "user_info",
                column: "here_to_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_job_title_id",
                table: "user_info",
                column: "job_title_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_personality_id",
                table: "user_info",
                column: "personality_id");

            migrationBuilder.CreateIndex(
                name: "UQ__user_inf__FB41DBCE2B5B5EA0",
                table: "user_info",
                column: "preference_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_info_relationship_id",
                table: "user_info",
                column: "relationship_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_religion_id",
                table: "user_info",
                column: "religion_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_sexuality_id",
                table: "user_info",
                column: "sexuality_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_smoking_id",
                table: "user_info",
                column: "smoking_id");

            migrationBuilder.CreateIndex(
                name: "UQ__user_inf__B9BE370E745ACBA2",
                table: "user_info",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_info_interest_interests_id",
                table: "user_info_interest",
                column: "interests_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_language_user_info_id",
                table: "user_info_language",
                column: "user_info_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_photo_user_info_id",
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
