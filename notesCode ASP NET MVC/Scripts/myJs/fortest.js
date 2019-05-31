document.getElementById('ok').onclick = checkRadio;
function checkRadio(){
    var right =  [1,3,3,2,2,1,1,1,2,1];
    var result = 0;
    var m = document.getElementsByName('question');
    for(var i= 0; i < m.length; i++){
        if(m[i].checked){
            var index = Math.floor(i/3);
            if(m[i].value == right[index]){
                 result++;
            }
            m[i].checked = false;
        }
    }
    alert('Правильних відповідей: '+result);
    //$.ajax({
	//	type: 'POST',
	//	url: '../php/update_test.php',
	//	data: {res : result},
	//	success: function(data){
	//		 console.log(data);
	//	 },
	//});
}