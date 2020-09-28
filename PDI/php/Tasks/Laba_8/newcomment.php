<html>
<body> 
<p>Добавить новый комментарий: </p>
<form action="newcomment.php" method="post">
<input type="text" name="author" size="20" maxlength="20" placeholder="Автор" required/><br>
<textarea name="comment" cols="55" rows="10"></textarea><br>
<input type="hidden" name = "created"
 value ="<?php echo date("Y-m-d");?>"/>
 <input type="hidden" name = "note_id"
 value ="<?php echo $_GET['note'];?>"/>
<input type="submit" name="submit" value="Отправить" />
</form>
<a href="blog.php">Возврат на главную страницу сайта</a>
</body>
</html>

<?php

require_once("MySiteDB.php");
$select_db = mysqli_select_db ($link, $db);

$author = $_POST['author'];
$created = $_POST['created'];
$comment = $_POST['comment'];
$id = $_POST['note_id'];

if (($author)&&($created)&&($comment))
 {
 $query = "INSERT INTO comments (author, created, comment,art_id) VALUES ('$author',
'$created', '$comment','$id')";
 $result = mysqli_query ($link, $query) or die("Ошибка " . mysqli_error($link));
 if($result){
  echo "<span style='color:blue;'>Данные добавлены</span>";
 }
 mysqli_close($link);
 }
?>