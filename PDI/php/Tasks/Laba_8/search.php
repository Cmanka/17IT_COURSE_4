<?php
require_once("MySiteDB.php");

$select = mysqli_select_db($link,$db);

$user_search = $_POST['query'];
$where_list = array();
$query_usersearch = "SELECT * FROM notes";
$clean_search = str_replace(',', ' ', $user_search);
$search_words = explode(' ', $user_search);
$final_search_words = array();

if (count($search_words) > 0)
 {
 foreach($search_words as $word) 
 {
 if (!empty($word))
 {
 $final_search_words[] = $word;
 }
 }
 }

foreach ($final_search_words as $word)
 {
 $where_list[] = " article LIKE '%$word%'";
 }
$where_clause = implode (' OR ', $where_list);
if (!empty($where_clause))
 {
 $query_usersearch .=" WHERE $where_clause";
 }
$res_query = mysqli_query($link, $query_usersearch);
$count_rows = mysqli_num_rows($res_query);
if($count_rows >=1){
  while ($res_array = mysqli_fetch_array($res_query))
  {
  echo $res_array['id'], "<br>";
  echo $res_array['title'], "<br/>";
  echo $res_array['article'], "<br>", "<hr>", "<br>";
  }

}
else{
  echo "По данному поиску '".$user_search."' записей не было найдено";
}

?> 
<br>
<a href="blog.php">Вернуться на главную страницу сайта</a>