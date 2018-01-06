import matplotlib
import matplotlib.pyplot
import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sns

imdbdata=pd.read_csv('/home/tanvi/Downloads/IMDB-Movie-Data.csv')

from os import path
from scipy.misc import imread
import matplotlib.pyplot as plt
import random

imdbdata=imdbdata.rename(columns = {'Revenue (Millions)':'Revenue_Millions'})
imdbdata=imdbdata.rename(columns = {'Runtime (Minutes)':'Runtime_Minutes'})

#DIRECTOR ANALYSIS :
imdbdata.Director.value_counts()[:10].plot.pie(autopct='%1.1f%%',figsize=(10,10))
plt.title('TOP 10 DIRECTORS OF MOVIES')
plt.show()

#ACTOR ANALYSIS
imdbdata.Actors.value_counts()[:10].plot.pie(autopct='%1.1f%%',figsize=(10,10))
plt.title('TOP 10 Actors OF MOVIES')
plt.show()

#YEAR ANALYSIS :
sns.stripplot(x="Year", y="Rating", data=imdbdata, jitter=True);
print(' RATING BASED ON YEAR')
plt.show

sns.swarmplot(x="Year", y="Votes", data=imdbdata);
print(' VOTES BASED ON YEAR')
#VOTES BASED ON YEAR
sns.stripplot(x="Year", y="Revenue_Millions", data=imdbdata, jitter=True);
print(' REVENUE BASED ON YEAR')

sns.swarmplot(x="Year", y="Metascore", data=imdbdata);
print(' METASCORE BASED ON YEAR')

#RATING ANALYSIS :

imdbdata["Rating"].value_counts()

#top 10 rating movies 
Sortedrating= imdbdata.sort_values(['Rating'], ascending=False)

#medium rated movies
mediumratedmovies= imdbdata.query('(Rating > 3.0) & (Rating < 7.0)')

sns.jointplot(x="Rating", y="Metascore", data=mediumratedmovies);
plt.title('(MOVIES WITH MEDIUM RATING , METASCORE')

sns.jointplot(x="Rating", y="Votes", data=mediumratedmovies);
plt.title('(MOVIES WITH MEDIUM RATING , VOTES')

sns.jointplot(x="Rating", y="Revenue_Millions", data=mediumratedmovies);
plt.title('(MOVIES WITH MEDIUM RATING , REVENUE')

highratedmovies= imdbdata.query('(Rating > 7.0) & (Rating < 10.0)')

sns.jointplot(x="Rating", y="Metascore", data=highratedmovies);
plt.title('(MOVIES WITH HIGH RATING , METASCORE')

sns.jointplot(x="Rating", y="Votes", data=highratedmovies);
plt.title('(MOVIES WITH HIGH RATING ,VOTES')

sns.jointplot(x="Rating", y="Revenue_Millions", data=highratedmovies);
plt.title('(MOVIES WITH HIGH RATING ,REVENUE')

metascore=imdbdata.Metascore
sns.boxplot(metascore);

plt.show()



