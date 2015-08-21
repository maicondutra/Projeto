	<?php
    $operation = $_GET["op"];
    $xmlFile = simplexml_load_file("AccountInfo.xml");
    $xmlLocalCopy = new SimpleXMLElement($xmlFile->asXML());
    if($operation == "sendInfo")
    {
        $username = $_GET["username"];
        $password = $_GET["password"];
        $newAcct = $xmlLocalCopy->addChild("Accounts"); 
        $newAcct->addChild("username", $username);
        $newAcct->addChild("password", $password);
        $dom = new DOMDocument('1.0');
        $dom->preserveWhiteSpace = false;
        $dom->formatOutput = true;
        $dom->loadXML($xmlLocalCopy->asXML());
        $dom->save("AccountInfo.xml");
        echo "Account Created.%login.html";
    }
?>
