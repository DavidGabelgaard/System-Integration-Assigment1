from flask import Flask
from System_Integration_Python import load_users_from_txt

app = Flask(__name__)

@app.route("/txt")
def hello_wolrd():
    return "Test"

