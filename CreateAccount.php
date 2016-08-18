<?php
//variables for the connection
	$servername = "localhost";
	$server_username = "root";
	$server_password = "lakers24";
	$dbname = "youtubeusers";
//variables for the user
	$username = $_REQUEST("");
	//$email = "test email";
	$password = $_REQUEST("");
	
	
	// make connection
	
	$conn = new mysqli($servername, $server_username, $server_password, $dbname);
	
	// check connection
	
	if(!$conn){
		die("Connection failed. ". mysqli_connect_error());
	}

	$sql = "INSERT INTO users (username, password)
			VALUES ('".$username."', '".$password."')";
	$result = mysqli_query($conn, $sql);

	if(!result) echo "There was an error";
	else echo "Everything ok";
?>