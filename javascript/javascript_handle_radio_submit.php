<?php
$checked = true;
?>

<script type='text/javascript'>
    function verifyPasscode() {
        let rgroupVal = document.querySelector('input[name="radio-group"]:checked').value;
        let inputVal = document.getElementById('input1').value;
        if ((rgroupVal === '1' || rgroupVal === '2') && inputVal === '') {
            alert('Passcode required when asking for passcode.');
            return false;
        } else {
            return true;
        }
    }

    function handleClick(btn) {
        let inputBox = document.getElementById('input1');
        if ((btn.value === '1' || btn.value === '2') && inputBox.value === '') { // change input border colour to red
            inputBox.style.borderColor = '#F00';
            // console.log('btn: ' + btn.value);
            // console.log('inputBox: ' + inputBox.value);
        } else { // change border colour to black
            inputBox.style.borderColor = '#000';
            // console.log('Not required: ' + btn.value);
        }
    }
</script>

<form type='submit' onsubmit='return verifyPasscode();'>
    <div>
        <label for='input1'>Required if radio 1 or 2:</label>
        <input type='text' id='input1' name='input1'></input>
    </div>
    <div>&nbsp;</div>
    <div>
        <label for="radio-group">Radio Group:</label>&nbsp;&nbsp;&nbsp;
        <input type='radio' id='radio1' name='radio-group' value='1' onclick='handleClick(this);' <?= $checked ? 'checked' : '' ?>><label for='radio1'>radio 1</label></input>
        <input type='radio' id='radio2' name='radio-group' value='2' onclick='handleClick(this);'><label for='radio2'>radio 2</label></input>
        <input type='radio' id='radio3' name='radio-group' value='3' onclick='handleClick(this);'><label for='radio3'>radio 3</label></input>
    </div>
    <div>&nbsp;</div>
    <div>
        <input type='submit' value='click me'></input>
    </div>
</form>
