// Close all tabs other than add people at page boot
$('.nav.navbar-nav > li').on('click', function (e) {
    $('.nav.navbar-nav > li').removeClass('active');
    $(this).addClass('active');
});  

$( document ).ready(function() {
    $("#edit_people").show(); 
    $("#people_edit_table").show();
    $("#edit_company").hide();
    $("#company_edit_table").hide();
    $("#edit_appointment").hide();
    $("#appointment_edit_table").hide();
    // console.log('gg');
});

// Only show add people tab
 $(document).on("click","#edit_options  div  div  div  ul  li:nth-child(1)  a",function() {
    $('#edit_options  div  div  div  ul  li.active').removeClass('active');
    $('#edit_options  div  div  div  ul  li:nth-child(1)').addClass('active');
    $("#edit_people").show(); 
    $("#people_edit_table").show();
    $("#edit_company").hide();
    $("#company_edit_table").hide();
    $("#edit_appointment").hide();
    $("#appointment_edit_table").hide();  
    });

// Only show add company tab
 $(document).on("click","#edit_options  div  div  div  ul  li:nth-child(2)  a",function() {
    $('#edit_options  div  div  div  ul  li.active').removeClass('active');
    $('#edit_options  div  div  div  ul  li:nth-child(2)').addClass('active');
    $("#edit_company").show();
    $("#company_edit_table").show();
    $("#edit_people").hide(); 
    $("#people_edit_table").hide();
    $("#edit_appointment").hide();
    $("#appointment_edit_table").hide();
        
    });

// Only show add appointment tab
 $(document).on("click","#edit_options  div  div  div  ul  li:nth-child(3)  a",function() {
    $('#edit_options  div  div  div  ul  li.active').removeClass('active');
    $('#edit_options  div  div  div  ul  li:nth-child(3)').addClass('active');
    $("#edit_appointment").show();
    $("#appointment_edit_table").show();
    $("#edit_people").hide(); 
    $("#people_edit_table").hide();
    $("#edit_company").hide();
    $("#company_edit_table").hide();  
    });


