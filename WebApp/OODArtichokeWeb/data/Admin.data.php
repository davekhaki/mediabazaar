<?php
  require ('PHPMailer/PHPMailerAutoload.php');
class Admin extends User{

  public function viewEmployee(){
  //  $db = new DB();
  //  $db= connect();
  $stmt = $this->connect()->query("SELECT * FROM employee");
  //$stmt->execute();
  //$stmt->fetchAll();
  echo '<th align = "center">ID</th>';
  echo '<th align = "center">Name</th>';
  echo '<th align = "center">Age</th>';
  echo '<th align = "center">Gender</th>';
  echo '<th align = "center">DepartmentName</th>';
  echo '<th align = "center">HireDate</th>';
  echo '<th align = "center">EndDate</th>';
  echo '<th align = "center">Adress</th>';

  foreach ( $stmt as $employee) {
  echo "<tr>
   <td>".$employee['ID']."</td>
   <td>".$employee['FirstName']." ".$employee['LastName']."</td>
   <td>".$employee['Age']."</td>
   <td>".$employee['Gender']."</td>
   <td>".$employee['DepartmentName']."</td>
  <td>".$employee['HireDate']."</td>
  <td>".$employee['EndDate']."</td>
  <td>".$employee['Adress']."</td></tr>";


  }
  }
public function passwordGen(){
  $alphabet = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890';
$pass = array(); //remember to declare $pass as an array
$alphaLength = strlen($alphabet) - 1; //put the length -1 in cache
for ($i = 0; $i < 8; $i++) {
   $n = rand(0, $alphaLength);
   $pass[] = $alphabet[$n];
}
return implode($pass); //turn the array into a string
}

public function sendLogin($username,$password){
  $emailTo="sebastianbokkestijn@gmail.com";
  $subject="Login";
  $from = "From: mediabazaarcompany@gmail.com";
  $emailBody = "username =". $username." password = ".$password;
  mail($emailTo,$subject,$emailBody,$from);
}

public function sendMail($name, $email, $password,$username){



$mail = new PHPMailer;

//$mail->SMTPDebug = 3;                               // Enable verbose debug output

$mail->isSMTP();                                      // Set mailer to use SMTP
$mail->Host = 'smtp.gmail.com';  // Specify main and backup SMTP servers
$mail->SMTPAuth = true;                               // Enable SMTP authentication
$mail->Username = 'mediabazaarcompany@gmail.com';                 // SMTP username
$mail->Password = 'ArtichokeGroup';                           // SMTP password
$mail->SMTPSecure = 'tls';                            // Enable TLS encryption, `ssl` also accepted
$mail->Port = 587;                                    // TCP port to connect to

$mail->setFrom('mediabazaarcompany@gmail.com', 'Login Info');
$mail->addAddress($email, $name);     // Add a recipient
//$mail->addAddress('ellen@example.com');               // Name is optional
//$mail->addReplyTo('info@example.com', 'Information');
//$mail->addCC('cc@example.com');
//$mail->addBCC('bcc@example.com');
//
//$mail->addAttachment('/var/tmp/file.tar.gz');         // Add attachments
//$mail->addAttachment('/tmp/image.jpg', 'new.jpg');    // Optional name
$mail->isHTML(true);                                  // Set email format to HTML

$mail->Subject = 'Login Info';
$mail->Body    = 'We are glad to have you in our team, <b>'.$name.'!</b>';
$mail->AltBody = 'Login info <p>Username: '.$username.'</p> <p>Password: '.$password.' </p>';

if(!$mail->send()) {
    echo 'Message could not be sent.';
    echo 'Mailer Error: ' . $mail->ErrorInfo;
} else {
    echo 'Message has been sent';
}
}

public function addEmployee($firstname,$lastname,$age,$gender,$department,$hiredate,$address,$role,$salary,$email){
  //$pass = $this->passwordGen();
  $pass = $this->passwordGen();;
//  $hashpassword = base64_encode($pass);
  $hashpassword = md5($pass);
  try{
  $stmt = $this->connect()->prepare("INSERT INTO employee(FirstName,LastName,Age,Gender,DepartmentName,HireDate,Adress,Role,Salary,E-mail) VALUES(?,?,?,?,?,?,?,?,?,?)");
  $stmt->execute([$firstname,$lastname,$age,$gender,$department,$hiredate,$address,$role,$salary,$email
]);
  $stmt1= $this->connect()->prepare("SELECT * FROM employee WHERE firstname = ? AND lastname = ?");
  $stmt1->execute([$firstname,$lastname]);
  $data=$stmt1->fetch(PDO::FETCH_OBJ);
  $id = $data->ID;
  $stmt2 = $this->connect()->prepare("INSERT INTO login(empId,username,password) VALUES(?,?,?)");
//$email = $this->sendLogin($firstn4ame."1",$pass);
$email =$this->sendMail($firstname." ".$lastname,$email,$firstname."1",$pas );
  $stmt2 ->execute([$id,$firstname."1",$hashpassword]);

  } catch(PDOException $e) {
  echo '{"error":{"text":'. $e->getMessage() .'}}';
  }

}
}
