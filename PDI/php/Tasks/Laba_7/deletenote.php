<?php
$note_id = $_GET['note'];
require_once ("MySiteDB.php");
$select_db = mysqli_select_db ($link, $db);
$query = "SELECT * FROM notes WHERE id = $note_id";
$result = mysqli_query ($link, $query);
$delete_note = mysqli_fetch_array ($result);
?>
<html>
<body>
<p>Страница удаления заметки </p>
<form id="editnote" name="editnote" method="post" >
<label for="title">Заголовок заметки</label><br>
<input readonly type="text" name="title" id="title"
 value = "<?php echo $delete_note['title'];?>" /><br>
<label for="article">Текст заметки </label><br>
<input readonly type="text" name=" article" id=" article"
 value = "<?php echo $delete_note['article'];?>" />
<input type="hidden" name = "note" id = "note"
 value="<?php echo $delete_note['id']?>" /><br>
<input type="hidden" name = "MM_update" value="editnote" />
<input type="submit" name="submit" id="submit" value="Удалить" />
</form> 
<?php
$submit = $_POST['submit'];
if ($submit)
 {
 $delete_query = "DELETE FROM notes WHERE id = $note_id";
 $delete_result = mysqli_query ($link, $delete_query);
 }
?>
<br>
<a href="blog.php">Вернуться на главную страницу сайта</a>
</body>
</html> 