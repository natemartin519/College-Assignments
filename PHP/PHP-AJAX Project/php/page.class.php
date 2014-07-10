<?php
	// Nathan Martin
	// March 08, 2010

	class page extends db{

		function __construct($user, $password, $host, $catalog){
			$this->db($user, $password, $host, $catalog);
		}


		function showHeader($title){
			$output = "<html><head><title>" . $title . "</title>";
			$output .= "<script type='text/javascript' src='js/YUI/connection-min.js'></script>";
			$output .= "<script type='text/javascript' src='js/javascript.js'></script>";
			$output .= "</head><body><div id='body'>";

			return $output;
		}


		function showFooter(){
			$output = "</div></body></html>";
			return $output;
		}


		function showList($sortCol = 1, $sortOrder = 0, $style="HTML"){

			$output = "<table border=1>";

			switch (intval($sortCol)){
				case 1:

					switch(intval($sortOrder)){
						case 0:
							$output .= "<tr style='background-color:#f0f0f0;' onMouseOver='this.style.cursor=\"pointer\"'><th onclick='sort(1, 1)'>ID</th>";
							break;
						case 1:
							$output .= "<tr style='background-color:#f0f0f0;' onMouseOver='this.style.cursor=\"pointer\"'><th onclick='sort(1, 0)'>ID</th>";
							break;
						default:
							return $this->error($style);
							break;
					}

					$output .= "<th onclick='sort(2, 0)'>Topic</th>";
					$output .= "<th onclick='sort(3, 0)'>Time</th></tr>";

					break;

				case 2:

					$output .= "<tr style='background-color:#f0f0f0;' onMouseOver='this.style.cursor=\"pointer\"'><th onclick='sort(1, 0)'>ID</th>";

					switch(intval($sortOrder)){
						case 0:
							$output .= "<th onclick='sort(2, 1)'>Topic</th>";
							break;
						case 1:
							$output .= "<th onclick='sort(2, 0)'>Topic</th>";
							break;
						default:
							return $this->error($style);
							break;
					}

					$output .= "<th onclick='sort(3, 0)'>Time</th></tr>";

					break;

				case 3:

					$output .= "<tr style='background-color:#f0f0f0;' onMouseOver='this.style.cursor=\"pointer\"'><th onclick='sort(1, 0)'>ID</th>";
					$output .= "<th onclick='sort(2, 0)'>Topic</th>";

					switch(intval($sortOrder)){
						case 0:
							$output .= "<th onclick='sort(3, 1)'>Time</th></tr>";
							break;
						case 1:
							$output .= "<th onclick='sort(3, 0)'>Time</th></tr>";
							break;
						default:
							return $this->error($style);
							break;
					}

					break;

				default:
					return $this->error($style);
					break;
			}


			$this->getList(intval($sortCol), intval($sortOrder));

			if ($this->req === false){
				return $this->error($style);
			} else {

				while($A=mysql_fetch_array($this->req)){
					$output .= "<tr onclick='displayTopic(" . $A['id'] . ")' onMouseOver='this.style.cursor=\"pointer\"'><td>" . $A['id'] . "</a></td>";
					$output .= "<td >" . $A['topic_name'] . "</td>";
					$output .= "<td>" . $A['datestamp'] . "</td></tr>";
				}

				$output .= "</table>";
			}


			switch ($style){
				case "XML":
					return $this->convertToXML($output);
					break;
				case "HTML":
					return $output;
					break;
				default:
					return $this->error();
					break;
			}
		}


		function showComment($topicID, $style="HTML"){
			$this->getComment(intval($topicID));

			if ($this->req === false){
				return $this->error($style);
			}

			$output = "<table border='1'><tr style='background-color:#f0f0f0;'><th>Comments</th><th>Date</th></tr>";

			while($A=mysql_fetch_array($this->req)){
				$output .= "<tr><td>" . $A['message'] . "</td>";
				$output .= "<td>" . $A['datestamp'] . "</td>";
				$output .= "</tr>";
			}

			$output .= "</table>";

			$output .= "<textarea id='comments' cols='40' rows='6'></textarea>";

			$output .= "<br /><span id='backButton' style='background-color:#6495ed; border-style:groove; border-width:2px; padding-right:50px; padding-left:50px;' onMouseOver='this.style.cursor=\"pointer\"' onclick='displayList()'>Back</span>";
			$output .= "<span id='postButton' style='background-color:#6495ed; border-style:groove; border-width:2px; padding-right:50px; padding-left:50px;' onMouseOver='this.style.cursor=\"pointer\"' onclick='post(" . $topicID . ")'>Post</span>";

			switch ($style){
				case "XML":
					return $this->convertToXML($output);
					break;
				case "HTML":
					return $output;
					break;
				default:
					return $this->error();
					break;
			}
		}


		function postComment($comment, $topicID){

			$commentClean = mysql_real_escape_string($comment);

			if (!empty($commentClean)){
				$this->setComment($commentClean, $topicID);
			}
		}


		function convertToXML($input){

			header("Cache-Control: no-store, no-cache, must-revalidate");
			header("content-type: application/xml");
			echo '<?xml version="1.0" encoding="utf-8"?>';

			$output = "<data>" . htmlentities($input) . "</data>";

			return $output;
		}


		function error($style = "HTML"){
			$output = "The site is currently down for maintenance, please try agian later.";

			switch ($style){
				case "XML":
					return $this->convertToXML($output);
					break;
				default:
					return $output;
					break;
			}
		}
	}
?>