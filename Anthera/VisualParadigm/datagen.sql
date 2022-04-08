USE Anthera;

INSERT INTO [dbo].[children] ([children_type])
     VALUES
           ('I''d perfer not to say'),
		   	('Grown up'),
		   ('Already have'),
		   ('No, never'),
		   ('Someday');

INSERT INTO [dbo].[drinking] ([drinking_type]) 
VALUES ('I''d perfer not to say'),
	   ('I drink socialy'),
       ('Never'),
       ('I drink often'),
       ('No, I''m sober');
       
INSERT INTO [dbo].[eye_colour] ([colour]) 
VALUES ('I''d perfer not to say'), 
	   ('Black'),
	   ('Blue'),
       ('Brown'),
       ('Green'),
       ('Grey'),
       ('Hazel'),
       ('Other');
       
INSERT INTO [dbo].[hair_colour] ([colour]) 
VALUES ('I''d perfer not to say'), 
	   ('Black'),
	   ('Blond'),
       ('Brown'),
       ('Dyed'),
       ('Grey'),
       ('Red'),
       ('Shaved'),
       ('White'),
       ('Bald');
       
INSERT INTO [dbo].[here_to] ([here_to_type]) 
VALUES ('I''d perfer not to say'),
	   ('Here to date'),
	   ('Open to chat'),
       ('For a realtionship');
       
INSERT INTO [dbo].[gender] ([gender_name]) 
VALUES ('I''d perfer not to say'),
	   ('Male'),
	   ('Female'),
       ('Other');
       
INSERT INTO [dbo].[job_title] ([title]) /* add more job titles */
VALUES ('I''d perfer not to say'),
	   ('Software Devloper'),
	   ('Singer'),
       ('Pianist');
       
INSERT INTO [dbo].[relationship] ([relationship_type]) 
VALUES ('I''d perfer not to say'),
	   ('It''s Complicated'),
	   ('I''m Single'),
       ('I''m Taken');
       
INSERT INTO [dbo].[sexuality] ([sexuality_type]) 
VALUES ('I''d perfer not to say'),
	   ('I''m Bisexual'),
	   ('Ask me'),
       ('I''m Straight');

INSERT INTO [dbo].[smoking] ([smoking_type]) 
VALUES ('I''d perfer not to say'),
	   ('I''m a heavy smoker'),
	   ('I hate smoking'),
       ('I smoke occasionally'),
       ('I don''t smoke');
       
INSERT INTO [dbo].[preference_sex] ([sex]) 
VALUES ('Female'),
	   ('Male'),
	   ('Both');


INSERT INTO [dbo].[religion] ([religion_name]) /* add more religions titles */
VALUES ('I''d perfer not to say'),
	   ('Catholic'),
	   ('Christain'),
	   ('Hindu');

INSERT INTO [dbo].[education_level] ([education_level_name])
VALUES ('I''d perfer not to say'),
	   ('High school'),
	   ('Diploma'),
	   ('Bachelors'),
	   ('Masters'),
	   ('Doctors');

INSERT INTO [dbo].[personality] ([personality_name]) 
VALUES ('I''d perfer not to say'),
	   ('Introvert'),
	   ('Extrovert'),
	   ('Somewhere in between');

INSERT INTO [dbo].[role] ([role_name]) 
VALUES ('ANTHEREA_USER'),
	   ('ANTHERA_ADMIN');
