<?php
	// Nathan Martin
	// March 08, 2010

	require_once('config.php');
	require_once('db.class.php');
	require_once('page.class.php');

	$page = new page($_CONFIG['db_user'], $_CONFIG['db_password'], $_CONFIG['db_host'], $_CONFIG['db_catalog']);


	switch ($_REQUEST['function']){

		case 'topic':
			if (isset($_REQUEST['topic'])){
				echo $page->showComment($_REQUEST['topic'], "XML");
			}else{
				echo $page->error();
			}

			break;

		case 'sort':
			if (isset($_REQUEST['sortcol']) && isset($_REQUEST['sortorder'])){
				echo $page->showList($_REQUEST['sortcol'], $_REQUEST['sortorder'], "XML");
			}else{
				echo $page->error();
			}

			break;

		case 'post':
			if (isset($_REQUEST['topic']) && isset($_REQUEST['comment'])){
				$page->postComment($_REQUEST['comment'], $_REQUEST['topic']);
				echo $page->showComment($_REQUEST['topic'], "XML");
			}else{
				echo $page->error();
			}

			break;

		default:
			echo $page->showList(1, 0, "XML");
			break;
	}

?>