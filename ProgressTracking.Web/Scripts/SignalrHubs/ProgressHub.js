(function ($) {
    $(document)
        .ready(function () {
            var initialJoke = true;
            var progressHub = $.connection.hub.proxies.progresshub;

            progressHub.client.updateProgress = function (progressModel) {
                if (progressModel !== null && typeof (progressModel) !== "undefined") {
                    $('.progress-message').html(progressModel.Message);
                    $('.progress-notification .progress-bar')
                        .attr('aria-valuenow', progressModel.PercentComplete)
                        .css('width', progressModel.PercentComplete + '%');

                    if (progressModel.IsComplete) {
                        $('.progress-message').html("Process Is Complete!!!");
                    }

                    if (progressModel.Joke !== "" && typeof (progressModel.Joke) !== "undefined") {
                        $(".joke").hide();

                        if (initialJoke) {
                            $(".chuck-container").animate({
                                'background-position-x': '100%'
                            }, 350, 'linear');

                            initialJoke = false;
                        }

                        $(".joke").html(progressModel.Joke).fadeIn(1000);
                    }
                }
            };

            $.connection.hub.start()
                .done(function () {
                    progressHub.server.subscribe();
                });

            $("#showProgress")
                .on('click',
                    function(e) {
                        $.post("/umbraco/api/ProgressApi/InitProgress");
                    });
        });
})(jQuery);