<?php
	// Nathan Martin
	// March 08, 2010

	class db{

		var $username;
		var $password;
		var $hostname;
		var $catalog;

		var $_DB;
		var $_CATALOG;

		var $req;

		function db($username,$password,$hostname,$catalog){
			$this->_DB=mysql_connect($hostname,$username,$password) or die('Cannot connect to DB server');
			$this->_CATALOG=mysql_select_db($catalog,$this->_DB) or die ('sorry, i cant access that database catalog');
		}


		function query($sql){
			$this->req=mysql_query ($sql, $this->_DB);
		}


		function getList($sortCol, $sortOrder){

			switch (intval($sortOrder)){
				case 0:
					$orderName = "ASC";
					break;
				case 1:
					$orderName = "DESC";
					break;
				default:
					$orderName = "ASC";
					break;
			}

			$sql = "SELECT id , topic_name , datestamp ";
			$sql .= "FROM main_topics ";

			switch (intval($sortCol)) {
			    case 1:
			        $sql .= "ORDER BY id " . $orderName;
			        break;
			    case 2:
			        $sql .= "ORDER BY topic_name " . $orderName;
			        break;
				case 3:
					$sql .= "ORDER BY datestamp " . $orderName;
			        break;
			}

			$this->query($sql);
		}


		function getComment($topicID){

			$sql = "SELECT message, datestamp ";
			$sql .= "FROM topic_entries ";
			$sql .= "WHERE main_topic_id = " . $topicID;

			$this->query($sql);
		}


		function setComment($comment, $topicID){
			$sql = "INSERT INTO topic_entries(main_topic_id, message, datestamp) ";
			$sql .= "VALUES ('" . $topicID . "', '" . $comment . "', CURDATE())";

			$this->query($sql);
		}

	}
?>