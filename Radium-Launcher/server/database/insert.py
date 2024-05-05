import psycopg
import configparser

conn = psycopg.connect(credential.secret)

cur = conn.cursor()

# cur.execute("TBD")

conn.commit()
conn.close()

input()