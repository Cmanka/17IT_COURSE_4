<?php
$note_id = $_GET['note'];
require_once ("MySiteDB.php");
$select_db = mysqli_select_db ($link, $db);
$query = "DELETE FROM notes WHERE id = $note_id";
$result = mysqli_query ($link, $query);
if($result){
  echo "Запись успешна удалена!";
}
?>
<br>
<a href="blog.php">Вернуться на главную страницу сайта</a>