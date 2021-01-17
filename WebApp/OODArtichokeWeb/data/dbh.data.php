<?php
session_start();
define("BASE_URL", "http://localhost/OODArtichokeWeb/");
class DB
{
	private $servername = "localhost";
	private	$dbUsername = "root";
	private $dbPassword = "";
	private $dbName = "artichoke";


	 function connect(){
		 try{
		$dsn = 'mysql:host=' . $this->servername . ';dbname=' . $this->dbName;
		$pdo = new PDO($dsn, $this->dbUsername, $this->dbPassword);
		$pdo->setAttribute(PDO::ATTR_DEFAULT_FETCH_MODE, PDO::FETCH_ASSOC);
		return $pdo;
	}
	catch(PDOException $e){
		echo 'Connection failed: ' . $e->getMessage();
	}
	}
}
?>
