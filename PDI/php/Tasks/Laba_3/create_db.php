<?php
$link = mysqli_connect("localhost","root","");
if($link){
  echo "Соединение с сервером установлено","<br/>";
}
else{
  echo "Нет соединения с сервером";
}
$db = "MySiteDB";
$query = "CREATE DATABASE $db";
$create_db = mysqli_query($link,$query);
if($create_db){
  echo "База данных $db успешно создана";
}
else{
  echo "База не создана";
}
?>