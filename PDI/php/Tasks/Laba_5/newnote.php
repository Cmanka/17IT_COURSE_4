<html>
<body> 
<p>Добавить новую заметку: </p>
<form action="newnote.php" method="post">
<input type="text" name="title" size="20" maxlength="20" placeholder="Заголовок" required/><br>
<textarea name="article" cols="55" rows="10"></textarea><br>
<input type="hidden" name = "created"
 value ="<?php echo date("Y-m-d");?>"/>
<input type="submit" name="submit" value="Отправить" />
</form>
<a href="blog.php">Возврат на главную страницу сайта</a>
</body>
</html>

<?php

require_once("MySiteDB.php");
$select_db = mysqli_select_db ($link, $db);

$title = htmlentities(mysqli_real_escape_string($link, $_POST['title']));
$created = htmlentities(mysqli_real_escape_string($link, $_POST['created']));
$article = htmlentities(mysqli_real_escape_string($link, $_POST['article']));

if (($title)&&($created)&&($article))
 {
 $query = "INSERT INTO notes (title, created, article) VALUES ('$title',
'$created', '$article')";
 $result = mysqli_query ($link, $query) or die("Ошибка " . mysqli_error($link));
 if($result){
  echo "<span style='color:blue;'>Данные добавлены</span>";
 }
 mysqli_close($link);
 }
?>