CREATE DATABASE DBMovies

USE DBMovies

CREATE SCHEMA Movies
DROP SCHEMA Movies

CREATE SCHEMA SMovies

SELECT NAME FROM SYS.DATABASES
SELECT * FROM SYS.SCHEMAS

ALTER DATABASE dbMovies
	MODIFY NAME = DBMovies

CREATE TABLE SMovies.Movies 
(MovieID char(10) CONSTRAINT pk_movie PRIMARY KEY CLUSTERED,
 Title varchar(30) NOT NULL,
 Genre  varchar(20) NOT NULL,
 Country varchar(20) NOT NULL,
 Year int NOT NULL,
 Duration int NOT NULL,)


CREATE TABLE SMovies.Actors
(ActorID char(10) CONSTRAINT pk_actor PRIMARY KEY CLUSTERED,
 ActFname varchar(20) NOT NULL,
 ActLname varchar(20) NOT NULL,
 Phone varchar(20) NOT NULL,
 BirthDate smalldatetime,
 Nationality varchar(20) NOT NULL,)

 alter table SMovies.Directors
 alter column datebirth date
 
CREATE TABLE SMovies.Directors
(DirectorID char(10) CONSTRAINT pk_dir PRIMARY KEY CLUSTERED,
 DirFname varchar(20) NOT NULL,
 DirLname varchar(20) NOT NULL,
 Phone varchar(20) NOT NULL,
 BirthDate smalldatetime,
 Nationality varchar(20) NOT NULL,)

CREATE TABLE SMovies.MovieCast
(ActorID char(10) CONSTRAINT fk_actor FOREIGN KEY
         REFERENCES SMovies.Actors(ActorID),
  MovieID char(10) CONSTRAINT fk_movie FOREIGN KEY
         REFERENCES SMovies.Movies(MovieID),
  Role varchar(20) NOT NULL,)

  alter table smovies.moviecast
  alter column role varchar(20)
  
CREATE TABLE SMovies.Ratings
(RatingID char(10) CONSTRAINT pk_rating PRIMARY KEY,
 MovieID char(10) CONSTRAINT fk_mov FOREIGN KEY
         REFERENCES SMovies.Movies(MovieID),
 RatingStars tinyint,
 NrRatings int,)

 ALTER TABLE SMovies.Ratings alter column ratingstars tinyint not null

CREATE TABLE SMovies.MovieDirection
(DirectorID char(10) CONSTRAINT fk_dir FOREIGN KEY
            REFERENCES SMovies.Directors(DirectorID),
 MovieID char(10) CONSTRAINT fk_m FOREIGN KEY
         REFERENCES SMovies.Movies(MovieID),)

ALTER TABLE SMovies.MovieCast DROP CONSTRAINT fk_actor 
ALTER TABLE SMovies.MovieCast DROP CONSTRAINT fk_movie 

ALTER TABLE SMovies.MovieCast ADD CONSTRAINT fk_actor 
FOREIGN KEY(ActorID)
REFERENCES SMovies.Actors(ActorID)
ON DELETE CASCADE ON UPDATE CASCADE

ALTER TABLE SMovies.MovieCast ADD CONSTRAINT fk_movie
FOREIGN KEY(MovieID)
REFERENCES SMovies.Movies(MovieID)
ON DELETE CASCADE ON UPDATE CASCADE

ALTER TABLE SMovies.MovieDirection DROP CONSTRAINT fk_dir 
ALTER TABLE SMovies.MovieDirection DROP CONSTRAINT fk_m

ALTER TABLE SMovies.MovieDirection ADD CONSTRAINT fk_dir 
FOREIGN KEY(DirectorID)
REFERENCES SMovies.Directors(DirectorID)
ON DELETE CASCADE ON UPDATE CASCADE

ALTER TABLE SMovies.MovieDirection ADD CONSTRAINT fk_m 
FOREIGN KEY(MovieID)
REFERENCES SMovies.Movies(MovieID)
ON DELETE CASCADE ON UPDATE CASCADE

ALTER TABLE SMovies.Ratings DROP CONSTRAINT fk_mov

ALTER TABLE SMovies.Ratings ADD CONSTRAINT fk_mov 
FOREIGN KEY(MovieID)
REFERENCES SMovies.Movies(MovieID)
ON DELETE CASCADE ON UPDATE CASCADE

ALTER TABLE SMovies.Ratings
 ADD CHECK(RatingStars between 1 and 10)

ALTER TABLE SMovies.Ratings
ADD Reviewer varchar(20) 

ALTER TABLE SMovies.Ratings
DROP COLUMN Reviewer

CREATE SYNONYM Movies FOR SMovies.Movies
DROP SYNONYM Movies

CREATE SYNONYM tMovies FOR SMovies.Movies
CREATE SYNONYM tActors FOR SMovies.Actors
CREATE SYNONYM tDirectors FOR SMovies.Directors
CREATE SYNONYM tMovieCast FOR SMovies.MovieCast
CREATE SYNONYM tMovieDir FOR SMovies.MovieDirection
CREATE SYNONYM tRatings FOR SMovies.Ratings

INSERT INTO  tMovies 
VALUES('M1','Avengers: Infinity war','Fantasy','USA','2018','149')
INSERT INTO  tMovies
VALUES('M2','Black Panther','Fantasy','USA','2018','134')
INSERT INTO  tMovies 
VALUES('M3','Lawrence of Arabia','Biography','Uk','1962','216')
INSERT INTO  tMovies 
VALUES('M4','Pacific Rim: Uprising','Sci-Fi','USA','2018','111')
INSERT INTO  tMovies 
VALUES('M5','Maze Runner: The Death Cure','Sci-Fi','USA','2018','141')
INSERT INTO  tMovies 
VALUES('M6','Tomb Rider','Adventure','USA','2018','108')
INSERT INTO  tMovies 
VALUES('M7','Ready Player One','Sci-Fi','USA','2018','140')
INSERT INTO  tMovies 
VALUES('M8','The Greatest Showman','Musical','USA','2017','105')
INSERT INTO  tMovies 
VALUES('M9','Star Wars: The Last Jedi','Fantasy','USA','2017','152')
INSERT INTO  tMovies 
VALUES('M10','Casablanca','Romance','USA','1942','102')
INSERT INTO  tMovies 
VALUES('M11','Vlad Tepes','History','Romania','1979','114')
INSERT INTO  tMovies 
VALUES('M12','Orient Express','Romance','Romania','2004','115')
INSERT INTO  tMovies 
VALUES('M13','La Dolce Vita','Comedy','Italia','1960','174')
INSERT INTO  tMovies 
VALUES('M14','Il Postino','Comedy','Italia','1994','108')
INSERT INTO  tMovies 
VALUES('M15','Beauty and the Beast','Fantasy','France','1946','93')


INSERT INTO  tActors 
VALUES('A1','Robert','Downey Jr.','424-288-2000','04-04-1965','American')
INSERT INTO  tActors 
VALUES('A2','Chris','Hemsworth','310-586-8222','11-08-1983','Australian')
INSERT INTO  tActors 
VALUES('A3','Peter','O Toole','203-936-2217','02-08-1932','British')
INSERT INTO  tActors 
VALUES('A4','Hugh','Jackman','310-285-9000','12-10-1968','Australian')
INSERT INTO  tActors 
VALUES('A5','Dylan','O Brian','310-446-1466','08-26-1991','American')
INSERT INTO  tActors 
VALUES('A6','Sergiu','Nicolaescu','0253-228 031','04-13-1930','Romanian')
INSERT INTO  tActors 
VALUES('A7','Amza','Pellea','0251-434 347','07-04-1931','Romanian')
INSERT INTO  tActors 
VALUES('A8','Jean','Marais','320-028-583','11-12-1913','French')
INSERT INTO  tActors 
VALUES('A9','Marcello','Mastroianni','0775 824 313','09-28-1924','Italian')
INSERT INTO  tActors 
VALUES('A10','Mark','Hamill','631-589-9068','09-25-1951','American')
INSERT INTO  tActors 
VALUES('A11','Alicia','Vikander','207 494 4767','03-10-1988','Swedish')
INSERT INTO  tActors 
VALUES('A12','Ingrid','Bergman','207 636 6565','08-29-1915','Swedish')
INSERT INTO  tActors 
VALUES('A13','Idris','Alba','207 439 1456','06-09-1972','British')
INSERT INTO  tActors 
VALUES('A14','Chadwick','Boseman','310-550-9333','11-29-1977','American')
INSERT INTO  tActors 
VALUES('A15','Olivia','Cooke','310-289-1088','12-27-1993','British')


INSERT INTO  tDirectors
VALUES
('D1','Anthony','Russo','512-251-5586','02-03-1970','American'),
('D2','Ryan','Coogler','800-698-2536','05-26-1986','American'),
('D3','David','Lean','0333 666 3366','03-25-1908','British'),
('D4','Steven','S.DeKnight','800-698-3357','04-08-1964','American'),       
('D5','Wes','Ball','865-670-8529','10-28-1980','American'),
('D6','Sergiu','Nicolaescu','0253-228 031','04-13-1930','Romanian'),
('D7','Doru','Nastase','021-435 187','02-02-1933','Romanian'),
('D8','Michael','Gracey','816-361-6458','01-13-1985','Australian'),
('D9','Rian','Johnson','0775 824 313','12-17-1973','American'),
('D10','Roar','Uthaug','310-273-6700','09-25-1951','Norwegian'),
('D11','Steven','Spielberg','310.288.4800','12-18-1946','American'),
('D12','Michael','Curtiz','361-278-5680','12-24-1886','Hungarian'),
('D13','Federico','Fellini','0984 398 238','01-20-1920','Italian'),
('D14','Jean','Cocteau','505-466-5528','07-05-1889','French'),
('D15','Michael','Radford','049-096-000','02-24-1946','Indian')


INSERT INTO tMovieCast(ActorID,MovieID,Role)
VALUES('A1','M1','Tony Stark/Iron Man')
INSERT INTO tMovieCast(ActorID,MovieID,Role)
VALUES('A2','M1','Thor')
INSERT INTO tMovieCast(ActorID,MovieID,Role)
VALUES('A3','M3','T.E. Lawrence')
INSERT INTO tMovieCast(ActorID,MovieID,Role)
VALUES('A4','M8','P.T. Barnum')
INSERT INTO tMovieCast(ActorID,MovieID,Role)
VALUES('A5','M5','Thomas')
INSERT INTO tMovieCast(ActorID,MovieID,Role)
VALUES('A6','M12','Andrei Morudzi')
INSERT INTO tMovieCast(ActorID,MovieID,Role)
VALUES('A7','M11','Mahmud Pasa')
INSERT INTO tMovieCast(ActorID,MovieID,Role)
VALUES('A8','M15','The Beast/The Prince')
INSERT INTO tMovieCast(ActorID,MovieID,Role)
VALUES('A9','M13','Marcello Rubini')
INSERT INTO tMovieCast(ActorID,MovieID,Role)
VALUES('A10','M9','Luke Skywalker')
INSERT INTO tMovieCast(ActorID,MovieID,Role)
VALUES('A11','M6','Lara Croft')
INSERT INTO tMovieCast(ActorID,MovieID,Role)
VALUES('A12','M10','Ilsa Lund')
INSERT INTO tMovieCast(ActorID,MovieID,Role)
VALUES('A13','M4','Stacker Pentecost')
INSERT INTO tMovieCast(ActorID,MovieID,Role)
VALUES('A14','M2','TChalla/BlackPanther')
INSERT INTO tMovieCast(ActorID,MovieID,Role)
VALUES('A15','M7','Art3mis/Samantha')


INSERT INTO tMovieDir
VALUES ('D1','M1')
INSERT INTO tMovieDir
VALUES ('D2','M2')
INSERT INTO tMovieDir
VALUES ('D3','M3')
INSERT INTO tMovieDir
VALUES ('D4','M4')
INSERT INTO tMovieDir
VALUES ('D5','M5')
INSERT INTO tMovieDir
VALUES ('D6','M12')
INSERT INTO tMovieDir
VALUES ('D7','M11')
INSERT INTO tMovieDir
VALUES ('D8','M8')
INSERT INTO tMovieDir
VALUES ('D9','M9')
INSERT INTO tMovieDir
VALUES ('D10','M6')
INSERT INTO tMovieDir
VALUES ('D11','M7')
INSERT INTO tMovieDir
VALUES ('D12','M10')
INSERT INTO tMovieDir
VALUES ('D13','M13')
INSERT INTO tMovieDir
VALUES ('D14','M15')
INSERT INTO tMovieDir
VALUES ('D15','M14')



INSERT INTO tRatings(RatingID,MovieID,RatingStars,NrRatings)
VALUES
('R1','M1','9','235773'),
('R2','M2','8','255074'),
('R3','M3','8','225590'),
('R5','M5','6','48515'),
('R6','M6','7','50834'),
('R7','M7','8','108679'),
('R8','M8','8','115435'),
('R9','M9','7','372265'),
('R10','M10','9','445587'),
('R11','M11','8','814'),
('R12','M12','6','817'),
('R13','M13','8','55406'),
('R14','M14','7','28976'),
('R15','M15','8','21114')

SELECT * FROM tMovies
SELECT * FROM tActors
SELECT * FROM tDirectors
SELECT * FROM tMovieCast
SELECT * FROM tMovieDir
SELECT * FROM tRatings

USE dbMovies
SELECT MovieID,Title,Year FROM tMovies

SELECT DISTINCT Year FROM tMovies

SELECT MovieID,Title,Year FROM tMovies
    WHERE Year>2000

SELECT MovieID,Title FROM tMovies
 WHERE Title LIKE 'B%'

SELECT MovieID,Title FROM tMovies
 WHERE Title LIKE '_[ea]%'
 
 SELECT MovieID,Title FROM tMovies
  WHERE Genre like 'F%' and Year>1960

SELECT MovieID,Title ,concat(Duration/60,'h', Duration%60,'min') as [Duration HM]
 FROM tMovies

SELECT Country,count(MovieID)
 FROM tMovies WHERE Year<>2018
 GROUP BY Country





