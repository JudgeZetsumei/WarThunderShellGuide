$(document).ready(function () {
    
    //////////// HTML TREE ////////////////////////////////////////
    $('#htmlTree').jstree();

    //////////// JSON TREE /////////////////////////////////////////    
    $("#jsonTree").jstree({
        "core": {
            "data": [
                {
                    "text": "Tanks",
                    'state': { 'opened': true },
                    "children": [
                                 {
                                     "text": "Britain",
                                     "children": [
                                         { "id": "3", "text": "Chieftain Mk2" }, { "id": "5", "text": "Chieftain Mk5" }, { "id": "6", "text": "Chieftain Mk10" }, { "id": "7", "text": "Chieftain Mk11" }]
                                 },
                                 {
                                     "text": "Jordan",
                                     "children": [
                                         { "id": "8", "text": "Chieftain Shir-I" }]
                                 },
                                 {
                                     "text": "Nazi Germany",
                                     "children": [{ "id": "1", "text": "Pz.Kpfw. III Ausf. M" }
                                     ]
                                 },
                                 {
                                     "text": "Soviet Russia",
                                     "children": [
                                         { "id": "2", "text": "T-34 1942" }]
                                 },
                                 {
                                     "text": "West Germany",
                                     "children": [
                                         { "id": "4", "text": "Chieftain Mk3" }]
                                 }
                    ]
                },
            ]
        },
        "plugins": ["themes", "json_data", "ui"]
    });

    $("#jsonTree").on("select_node.jstree",
        function (evt, data) {
            $.ajax({
                url: "/Home/ShellDetails",
                data: { "tankId": data.node.id },
                success: function (data) {
                    $(".stats").hide();
                    $('.stats').html(data);                    
                    $(".stats").fadeIn("slow");
                }
            });
        }
        );

    /////////// AJAX JSON TREE//////////////////////////////////////
    $(function () {
        $.ajax({
            async: true,
            type: "GET",
            url: "/Home/BuildTankTree",
            dataType: "json",

            success: function (json) {
                createJSTree(json);
            },
        });
    });

    function createJSTree(jsonData) {
        $("#ajaxJsonTree").jstree({
            'core': {
                'data': jsonData
            },
            'plugins': ['themes', 'json_data', 'ui']
        });
    }
    $("#ajaxJsonTree").on("select_node.jstree",
        function (evt, data) {
            $.ajax({
                url: "/Home/ShellDetails",
                data: { "tankId": data.node.id },
                success: function (data) {
                    $(".stats").hide();                   
                    $('.stats').html(data);
                    $(".stats").fadeIn("slow");
                }
            });
        }
            );

    ///////////// PICTURE TANK LIST HOVER DETAILS ///////////////////
    $('.tankBox').mouseover(function () {
        var tankId = $(this).data('tank-id');

        $.ajax({
            url: "/Home/ShellDetails",
            data: { "tankId": tankId },
            success: function (data) {
                $(".stats").hide();
                $('.stats').html(data);
                $(".stats").fadeIn("slow");
            }
        });
    });

    /////////////// jquery ui tabs //////////////////////////////////
    //$("#tabs").tabs()({
    //    activate: function (event, ui) {}
    //});

    //$("#tabs").on("tabsactivate", function (event, ui) {
    //    $(".stats").hide();
    //});

    $('ul.tabs').each(function () {
        // For each set of tabs, we want to keep track of
        // which tab is active and it's associated content
        var $active, $content, $links = $(this).find('a');

        // If the location.hash matches one of the links, use that as the active tab.
        // If no match is found, use the first link as the initial active tab.
        $active = $($links.filter('[href="' + location.hash + '"]')[0] || $links[0]);
        $active.addClass('active');

        $content = $($active[0].hash);

        // Hide the remaining content
        $links.not($active).each(function () {
            $(this.hash).hide();
        });

        // Bind the click event handler
        $(this).on('click', 'a', function (e) {
            // Make the old tab inactive.
            $active.removeClass('active');
            $content.hide();

            // Update the variables with the new link and content
            $active = $(this);
            $content = $(this.hash);

            // Hide Graph to avoid overlay issue
            $(".stats").hide();

            // Make the tab active.           
            $active.addClass('active');
            $content.show();

            // Prevent the anchor's default click action
            e.preventDefault();
        });
    });

    /////////////// HTML DataTable /////////////////////////////   
    $('#htmlTable').DataTable();
    

    ////////////// Json Ajax DataTable /////////////////////////   
    $('#jsonTable').DataTable({        
        "bServerSide": true,       
        "bProcessing": true,
        "sAjaxSource": "/Home/BuildDataTable",
    });
});

//"columns": [
//            { "data": "Name" },
//            { "data": "Nation" },
//            { "data": "Class" },
//            { "data": "BattleRating" }
//]
