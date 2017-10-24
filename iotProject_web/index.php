<!DOCTYPE html>
<html lang="en">
    <?php
    $data_string= "DATABASE STATUS : ...";
        if (!$link = mysql_connect('localhost:3306', 'root', '')) {
            $data_string= "DATABASE STATUS : ". mysql_error();
        }
        else{
            $initial_string= "DATABASE STATUS : database connection made successfully";
            if (!$db_selected = mysql_select_db('iotproject_1', $link)) {
                $data_string= "DATABASE STATUS : " . mysql_error();
            }
            else{
                $data_string= "DATABASE STATUS : database found successfully";
                if(isset($_POST['led_1_onn'])){
                    $data_string= "DATA STRING : led_1_onn";
                    $sqlstring = "UPDATE `table_led` SET `status` = '1' WHERE `table_led`.`id` = 1";
                    $dataquery = mysql_query($sqlstring, $link);
                }
                if(isset($_POST['led_1_off'])){
                    $data_string="DATA STRING : led_1_off";
                    $sqlstring = "UPDATE `table_led` SET `status` = '0' WHERE `table_led`.`id` = 1";
                    $dataquery = mysql_query($sqlstring, $link);
                }
                if(isset($_POST['led_2_onn'])){
                    $data_string= "DATA STRING : led_2_onn";
                    $sqlstring = "UPDATE `table_led` SET `status` = '1' WHERE `table_led`.`id` = 2";
                    $dataquery = mysql_query($sqlstring, $link);
                }
                if(isset($_POST['led_2_off'])){
                    $data_string= "DATA STRING : led_2_off";
                    $sqlstring = "UPDATE `table_led` SET `status` = '0' WHERE `table_led`.`id` = 2";
                    $dataquery = mysql_query($sqlstring, $link);
                }
                if(isset($_POST['led_3_onn'])){
                    $data_string= "DATA STRING : led_3_onn";
                    $sqlstring = "UPDATE `table_led` SET `status` = '1' WHERE `table_led`.`id` = 3";
                    $dataquery = mysql_query($sqlstring, $link);
                }
                if(isset($_POST['led_3_off'])){
                    $data_string="DATA STRING : led_3_off";
                    $sqlstring = "UPDATE `table_led` SET `status` = '0' WHERE `table_led`.`id` = 3";
                    $dataquery = mysql_query($sqlstring, $link);
                }
                if(isset($_POST['led_4_onn'])){
                    $data_string= "DATA STRING : led_4_onn";
                    $sqlstring = "UPDATE `table_led` SET `status` = '1' WHERE `table_led`.`id` = 4";
                    $dataquery = mysql_query($sqlstring, $link);
                }
                if(isset($_POST['led_4_off'])){
                    $data_string="DATA STRING : led_4_off";
                    $sqlstring = "UPDATE `table_led` SET `status` = '0' WHERE `table_led`.`id` = 4";
                    $dataquery = mysql_query($sqlstring, $link);
                }
                if(isset($_POST['led_5_onn'])){
                    $data_string= "DATA STRING : led_5_onn";
                    $sqlstring = "UPDATE `table_led` SET `status` = '1' WHERE `table_led`.`id` = 5";
                    $dataquery = mysql_query($sqlstring, $link);
                }
                if(isset($_POST['led_5_off'])){
                    $data_string="DATA STRING : led_5_off";
                    $sqlstring = "UPDATE `table_led` SET `status` = '0' WHERE `table_led`.`id` = 5";
                    $dataquery = mysql_query($sqlstring, $link);
                }
                if(isset($_POST['led_6_onn'])){
                    $data_string= "DATA STRING : led_6_onn";
                    $sqlstring = "UPDATE `table_led` SET `status` = '1' WHERE `table_led`.`id` = 6";
                    $dataquery = mysql_query($sqlstring, $link);
                }
                if(isset($_POST['led_6_off'])){
                    $data_string="DATA STRING : led_6_off";
                    $sqlstring = "UPDATE `table_led` SET `status` = '0' WHERE `table_led`.`id` = 6";
                    $dataquery = mysql_query($sqlstring, $link);
                }
            }
        }
    ?>
    <head>
        <title>IOT DEMO</title>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet" href="css/bootstrap.min.css">
    </head>
    <body>
        <div class="row">
            <div class="col-sm-1"></div>
            <div class="col-sm-10">
            <div class="alert alert-info">
                <button type="button" class="close" data-dismiss="alert">&times;</button>
                <strong>SENDING DATA TO SERVER ...!!!</strong>
                <br>
                <label><?php if(isset($data_string)){ echo $data_string;}?></label>
            </div>
            <form method="post">
                <fieldset>
                    <legend>LED CONTROL PANEL</legend>
                    <div class="row">
                        <div class="col-sm-2"></div>
                        <div class="col-sm-8">
                            <div class="form-group">
                                <label class="control-label">LED ONE STATUS</label>
                                <div class="text-right">
                                    <div id="led_1_Group" class="btn-group" role="group" aria-label="LED ONE STAUS">
                                        <button type="submit" id="led_1_onn" name="led_1_onn" class="btn btn-success btn-lg" aria-label="LED ONN">LED ONN</button>
                                        <button type="submit" id="led_1_off" name="led_1_off" class="btn btn-danger btn-lg" aria-label="LED OFF">LED OFF</button>
                                    </div>
                                    <p class="help-block">led number one control panel</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-2"></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2"></div>
                        <div class="col-sm-8">
                            <div class="form-group">
                                <label class="control-label">LED TWO STATUS</label>
                                <div class="text-right">
                                    <div id="led_2_Group" class="btn-group" role="group" aria-label="LED TWO STATUS">
                                        <button type="submit" id="led_2_onn" name="led_2_onn" class="btn btn-success btn-lg" aria-label="LED ONN">LED ONN</button>
                                        <button type="submit" id="led_2_off" name="led_2_off" class="btn btn-danger btn-lg" aria-label="LED OFF">LED OFF</button>
                                    </div>
                                    <p class="help-block">led number two control panel</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-2"></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2"></div>
                        <div class="col-sm-8">
                            <div class="form-group">
                                <label class="control-label">LED THREE STATUS</label>
                                <div class="text-right">
                                    <div id="led_3_Group" class="btn-group" role="group" aria-label="LED THREE STATUS">
                                        <button type="submit" id="led_3_onn" name="led_3_onn" class="btn btn-success btn-lg" aria-label="LED ONN">LED ONN</button>
                                        <button type="submit" id="led_3_off" name="led_3_off" class="btn btn-danger btn-lg" aria-label="LED OFF">LED OFF</button>
                                    </div>
                                    <p class="help-block">led number three control panel</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-2"></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2"></div>
                        <div class="col-sm-8">
                            <div class="form-group">
                                <label class="control-label">LED FOUR STATUS</label>
                                <div class="text-right">
                                    <div id="led_4_Group" class="btn-group" role="group" aria-label="LED FOUR STATUS">
                                        <button type="submit" id="led_4_onn" name="led_4_onn" class="btn btn-success btn-lg" aria-label="LED ONN">LED ONN</button>
                                        <button type="submit" id="led_4_off" name="led_4_off" class="btn btn-danger btn-lg" aria-label="LED OFF">LED OFF</button>
                                    </div>
                                    <p class="help-block">led number four control panel</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-2"></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2"></div>
                        <div class="col-sm-8">
                            <div class="form-group">
                                <label class="control-label">LED FIVE STATUS</label>
                                <div class="text-right">
                                    <div id="led_5_Group" class="btn-group" role="group" aria-label="LED THREE STATUS">
                                        <button type="submit" id="led_5_onn" name="led_5_onn" class="btn btn-success btn-lg" aria-label="LED ONN">LED ONN</button>
                                        <button type="submit" id="led_5_off" name="led_5_off" class="btn btn-danger btn-lg" aria-label="LED OFF">LED OFF</button>
                                    </div>
                                    <p class="help-block">led number five control panel</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-2"></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2"></div>
                        <div class="col-sm-8">
                            <div class="form-group">
                                <label class="control-label">LED SIX STATUS</label>
                                <div class="text-right">
                                    <div id="led_6_Group" class="btn-group" role="group" aria-label="LED SIX STATUS">
                                        <button type="submit" id="led_6_onn" name="led_6_onn" class="btn btn-success btn-lg" aria-label="LED ONN">LED ONN</button>
                                        <button type="submit" id="led_6_off" name="led_6_off" class="btn btn-danger btn-lg" aria-label="LED OFF">LED OFF</button>
                                    </div>
                                    <p class="help-block">led number six control panel</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-2"></div>
                    </div>
                </fieldset>
            </form>
        </div>
            <div class="col-sm-1"></div>
    </div>
    </body>
        <script src="js/jquery.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
</html>