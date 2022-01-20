-- Script Date: 1/19/2022 10:42 PM  - ErikEJ.SqlCeScripting version 3.5.2.90
CREATE TABLE [Movie] (
  [MovieId] INTEGER NOT NULL
, [Title] TEXT NOT NULL
, [MoviedetailsId] INTEGER NOT NULL
, CONSTRAINT [PK_Movie] PRIMARY KEY ([MovieId])
);
