<?php
	// Nathan Martin
	// March 08, 2010

	require_once('php/config.php');
	require_once('php/db.class.php');
	require_once('php/page.class.php');

	$page = new page($_CONFIG['db_user'], $_CONFIG['db_password'], $_CONFIG['db_host'], $_CONFIG['db_catalog']);

	echo $page->showHeader('PHP & Ajax Project');
	echo $page->showList();
	echo $page->showFooter();

?>