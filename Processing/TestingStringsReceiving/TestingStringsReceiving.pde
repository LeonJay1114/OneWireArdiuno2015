import processing.serial.*;
import java.io.*;

int baudRate = 9600;
int mySerialPort = 0; // Change this to the port number of the Arduino
Serial myPort;
FileWriter output;

void setup () {
  println(Serial.list());
  myPort = new Serial(this, Serial.list()[mySerialPort], baudRate);

  // don't generate a serialEvent() unless you get a newline character:
  myPort.bufferUntil('\n');

  size(600, 100);
  textSize(18);
  text("Received UID:", 10, 30);
  try {
    String filePath = sketchPath("data.csv");
    println("File path: "+filePath);
    File file = new File(filePath);
    if (!file.exists()) {
      print("File does not exist: "+filePath);
      println(" Creating...");
      if (!file.createNewFile()) {
        println("Cannot create file "+filePath);
      }
    }
    output = new FileWriter(file, true);
  }
  catch(IOException e) {
    println("Cannot open file for writing");
    e.printStackTrace();
  }
}

void stop() {
  try {
    output.close();
  }
  catch(IOException e) {
    println("Cannot close file");
    e.printStackTrace();
  }
}

String newUID = "";
void draw() {
  fill(0);
  rect(10, 40, 550, 30);
  fill(255);
  text(newUID, 15, 60);
}

String inString;
String dataMarker = "$data:";
void serialEvent(Serial p) {
  inString = p.readString();
  println("Received line: "+inString);
  
  newUID = inString;
  
}

