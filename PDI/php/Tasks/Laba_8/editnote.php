<?php
$note_id = $_GET['note'];
require_once ("MySiteDB.php");
$select_db = mysqli_select_db ($link, $db);
$query = "SELECT * FROM notes WHERE id = $note_id";
$result = mysqli_query ($link, $query);
$edit_note = mysqli_fetch_array ($result);
?>
<html>
<body>
<p>Страница редактирования заметки </p>
<form id="editnote" name="editnote" method="post" >
<label for="title">Заголовок заметки</label><br>
<input type="text" name="title" id="title"
 value = "<?php echo $edit_note['title'];?>" /><br>
<label for=" article">Текст заметки </label><br>
<textarea name=" article" id=" article">
 <?php echo $edit_note['article'];?></textarea><br>
 <input type="hidden" name = "note" id = "note"
 value="<?php echo $edit_note['id']?>" />
<input type="submit" name="submit" id="submit" value="Изменить" />
</form>
<a href="blog.php">Вернуться на главную страницу сайта</a>
</body>
</html> 
<?php
$title = $_POST['title'];
$article = $_POST['article'];
$update_query = "UPDATE notes SET title = '$title', article = '$article'
 WHERE id = $note_id";
$update_result = mysqli_query ($link, $update_query);
?> 