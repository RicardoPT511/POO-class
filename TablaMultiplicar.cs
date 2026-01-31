<html>
<head>
<title>Program.cs</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<style type="text/css">
.s0 { color: #d0d0d0;}
.s1 { color: #6c95eb;}
.s2 { color: #bdbdbd;}
.s3 { color: #c9a26d;}
.s4 { color: #ed94c0;}
</style>
</head>
<body bgcolor="#191a1c">
<table CELLSPACING=0 CELLPADDING=5 COLS=1 WIDTH="100%" BGCOLOR="#606060" >
<tr><td><center>
<font face="Arial, Helvetica" color="#000000">
Program.cs</font>
</center></td></tr></table>
<pre>
<span class="s1">int </span><span class="s0">Num</span><span class="s2">,</span><span class="s0">Producto</span><span class="s2">;</span>

<span class="s0">Console</span><span class="s2">.</span><span class="s0">WriteLine</span><span class="s2">(</span><span class="s3">&quot;Ingrese un nuemro entero &quot;</span><span class="s2">);</span>
<span class="s0">Num</span><span class="s2">= </span><span class="s1">int</span><span class="s2">.</span><span class="s0">Parse</span><span class="s2">(</span><span class="s0">Console</span><span class="s2">.</span><span class="s0">ReadLine</span><span class="s2">());</span>

<span class="s0">Console</span><span class="s2">.</span><span class="s0">WriteLine</span><span class="s2">(</span><span class="s3">&quot;La tabla del :&quot; </span><span class="s2">+ </span><span class="s0">Num</span><span class="s2">);</span>
<span class="s1">for </span><span class="s2">(</span><span class="s1">int </span><span class="s0">i </span><span class="s2">= </span><span class="s4">0</span><span class="s2">; </span><span class="s0">i </span><span class="s2">&lt;= </span><span class="s4">10</span><span class="s2">; </span><span class="s0">i</span><span class="s2">++)</span>
<span class="s2">{</span>
    <span class="s0">Producto</span><span class="s2">=</span><span class="s0">Num </span><span class="s2">* </span><span class="s0">i</span><span class="s2">;</span>
    <span class="s0">Console</span><span class="s2">.</span><span class="s0">WriteLine</span><span class="s2">(</span><span class="s0">Producto</span><span class="s2">);</span>
    
<span class="s2">}</span>
</pre>
</body>
</html>