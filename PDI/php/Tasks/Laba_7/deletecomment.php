<?php
$comment_id = $_GET['comment'];
require_once ("MySiteDB.php");
$select_db = mysqli_select_db ($link, $db);
$query = "SELECT * FROM comments WHERE id = $comment_id";
$result = mysqli_query ($link, $query);
if($result){
  echo "Комментарий был успешно удален";
}
?>

<br>
<a href="blog.php">Вернуться на главную страницу сайта</a>