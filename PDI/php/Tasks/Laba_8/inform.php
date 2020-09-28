<?php
require_once("MySiteDB.php");
$select = mysqli_select_db($link,$db);
//notes
$query_allnotes = "SELECT COUNT(id) AS allnotes FROM notes";
$allnotes = mysqli_query ($link, $query_allnotes) or die (mysqli_error());
$row_allnotes = mysqli_fetch_assoc ($allnotes);
$allnotes_num = $row_allnotes['allnotes'];
mysqli_free_result ($allnotes);
//comments
$query_allcoments = "SELECT COUNT(id) AS allcomments FROM comments";
$allcomments = mysqli_query($link,$query_allcoments) or die(mysqli_error());
$row_allcoments = mysqli_fetch_assoc($allcomments);
$allcoments_num = $row_allcoments['allcomments'];
mysqli_free_result($allcomments);
// notes last month
$date_array = getdate(); 

$begin_date = date ("Y-m-d", mktime(0,0,0, $date_array['mon'],1, $date_array['year'])); 
$end_date = date ("Y-m-d", mktime(0,0,0, $date_array['mon'] + 1,0, $date_array['year']));

$query_lmnotes = "SELECT COUNT(id) AS lmnotes FROM notes
 WHERE created>='$begin_date' AND created<='$end_date'";
$lmnotes = mysqli_query ($link, $query_lmnotes)or die (mysqli_error());
$row_lmnotes = mysqli_fetch_assoc ($lmnotes);
$lmnotes_num = $row_lmnotes['lmnotes'];
mysqli_free_result ($lmnotes); 
//comments last month
$query_lmcomments = "SELECT COUNT(id) AS lmcomments FROM comments
 WHERE created>='$begin_date' AND created<='$end_date'";
$lmcomments = mysqli_query ($link, $query_lmcomments)or die (mysqli_error());
$row_lmcomments = mysqli_fetch_assoc ($lmcomments);
$lmcomments_num = $row_lmcomments['lmcomments'];
mysqli_free_result ($lmcomments); 
//Last note

$query_last_note = "SELECT id, title FROM notes
 ORDER BY id DESC LIMIT 0,1";
$lastnote = mysqli_query ($link, $query_last_note) or die (mysqli_error());
$row_lastnote = mysqli_fetch_assoc ($lastnote);
mysqli_free_result ($lastnote);
$result_lastnote = $row_lastnote['title'];

//popular note
$query_mcnote = "SELECT notes.id, notes.title FROM comments, notes
 WHERE comments.art_id=notes.id 
 GROUP BY notes.id
 ORDER BY COUNT(comments.id) DESC LIMIT 0,1";
$popularnote = mysqli_query($link,$query_mcnote) or die(mysqli_error());
$row_popularnote = mysqli_fetch_assoc($popularnote);
mysqli_free_result($popularnote);
$result_popularnote = $row_popularnote['title'];
?>

<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="UTF-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1.0" />
		<title>Document</title>
	</head>
	<body>
		<h3>Полезная инофрмация:</h3>
		<hr />
		<div>
			<p>Сделано записей - <?php echo $allnotes_num;?></p>
			<p>Оставлено комментариев - <?php echo $allcoments_num;?> </p>
			<p>За последний месяц я создал записей - <?php echo $lmnotes_num;?></p>
			<p>За последний месяц оставлено комментариев - <?php echo $lmcomments_num;?></p>
			<p>Моя последняя запись - <?php echo $result_lastnote;?></p>
			<p>Самая обсуждаемся запись - <?php echo $result_popularnote;?></p>
			<br />
			<a href="blog.php">На главную страницу сайта</a>
		</div>
	</body>
</html>
