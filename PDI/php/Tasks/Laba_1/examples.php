<?php
$a = 10;
$b = 20;

echo "A=$a <br/> B=$b <br/>";

$c = $a + $b;

echo "C=A+B=$c <br/>";

$c *=3;

echo "C*=3=$c <br/>";

$c /= ($b-$a);

echo "C = C/(B-A) = $c <br/>";

$p = "Программа";
$b = "Работает";

$result = $p . " " . $b;
$result .=" хорошо";
echo "$result <br/>";

$q = 5;
$w = 7;

echo "Q = $q <br/> W = $w <br/>";

$q = $q + $w;
$w = $q - $w;
$q = $q - $w;

echo "Q = $q <br/> W = $w <br/>";

?>