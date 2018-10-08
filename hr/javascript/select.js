$(function(){    
 	$("#firstKindId").change(function(){ 
 		var strText=$("#firstKindId").find("option:selected").text();   //获取Select选择的text
 	  	$("#firstKindName").val(strText);
 		
 	});
 	$("#secondKindId").change(function(){
 		var secondText = $("#secondKindId").find("option:selected").text();
 		$("#secondKindName").val(secondText);
 		
 	
 	});
 	
 	$("#thirdKindId").change(function(){
 		var thirdText = $("#thirdKindId").find("option:selected").text();
 		
 		$("#thirdKindName").val(thirdText);
 		
 	});
 	});
 
$(function(){
	$("#majorKindId").change(function(){
		var thirdText = $("#majorKindId").find("option:selected").text();
		$("#majorKindName").val(thirdText);
		
		
	});
	$("#majorId").change(function () {
		var majorIdText = $("#majorId").find("option:selected").text();
		$("#majorName").val(majorIdText);
	});
	
});