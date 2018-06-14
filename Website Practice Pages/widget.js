// https://www.sociablekit.com/app/embed/instagram-hashtag-feed/widget.js 'name of the area'

(function(window, document){"use strict";  /* Wrap code in an IIFE */

// Localize jQuery variables
var jQuery, $ = window.jQuery;
var app_url=getDsmAppUrl();

// loading animation
var el = document.getElementsByClassName('sk-ww-instagram-hashtag-feed')[0];
el.innerHTML = "<div class='first_loading_animation' style='text-align:center; width:100%;'><img src='" + app_url + "images/ripple.svg' class='loading-img' style='width:auto !important;' /></div>";

// load css
loadCssFile(app_url + "embed/instagram-hashtag-feed/libs/js/magnific-popup/magnific-popup.css");
loadCssFile(app_url + "embed/instagram-hashtag-feed/widget_css.php");
loadCssFile("https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css");

/******** Load jQuery if not present *********/
if (window.jQuery === undefined || window.jQuery.fn.jquery !=='3.1.1') {
    var script_tag = document.createElement('script');
    script_tag.setAttribute("type","text/javascript");
    script_tag.setAttribute("src", "https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js");
    if (script_tag.readyState) {
      script_tag.onreadystatechange = function () { // For old versions of IE
          if (this.readyState == 'complete' || this.readyState == 'loaded') {
              scriptLoadHandler();
          }
      };
    } else {
      script_tag.onload = scriptLoadHandler;
    }
    // Try to find the head, otherwise default to the documentElement
    (document.getElementsByTagName("head")[0] || document.documentElement).appendChild(script_tag);
} else {
    // The jQuery version on the window is the one we want to use
    jQuery = window.jQuery;
    scriptLoadHandler();
}

function getDsmAppUrl(){

    // auto detect live and dev version
    var scripts = document.getElementsByTagName("script");
    var scripts_length=scripts.length;
    var search_result=-1; // not app-dev
    var app_dev=false;

    for(var i=0; i<scripts_length; i++){
        var src_str=scripts[i].getAttribute('src');

        if(src_str!=null){
            search_result=src_str.search("app-dev");

            // app-dev found if greater than or equal to 1
            if(search_result>=1){ app_dev=true; }
        }
    }

    // app url
    var app_url="https://www.sociablekit.com/app/";

    if(app_dev==true){
        app_url="https://www.sociablekit.com/app-dev/";
    }

    return app_url;
}

function getDsmEmbedId(sk_instagram_feed){
    var embed_id = sk_instagram_feed.attr('embed-id');
    if(embed_id==undefined){ embed_id = sk_instagram_feed.attr('data-embed-id'); }
    return embed_id;
}

function getDsmSetting(sk_instagram_feed, key){
    return sk_instagram_feed.find("." + key).text();
}

function loadScript(url, callback){

	/* Load script from url and calls callback once it's loaded */
	var scriptTag = document.createElement('script');
	scriptTag.setAttribute("type", "text/javascript");
	scriptTag.setAttribute("src", url);

	if (typeof callback !== "undefined") {
		if (scriptTag.readyState) {
			/* For old versions of IE */
			scriptTag.onreadystatechange = function(){
				if (this.readyState === 'complete' || this.readyState === 'loaded') {
					callback();
				}
			};
		} else {
			scriptTag.onload = callback;
		}
	}
	(document.getElementsByTagName("head")[0] || document.documentElement).appendChild(scriptTag);
}

/******** Called once jQuery has loaded ******/
function scriptLoadHandler() {

    loadScript(app_url + "embed/instagram-hashtag-feed/libs/js/magnific-popup/jquery.magnific-popup.min.js", function(){

        // Restore $ and window.jQuery to their previous values and store the
        // new jQuery in our local jQuery variable
        $ = jQuery = window.jQuery.noConflict(true);

        // Call our main function
        main();
    });

}

// load css file
function loadCssFile(filename){

    var fileref=document.createElement("link");
    fileref.setAttribute("rel", "stylesheet");
    fileref.setAttribute("type", "text/css");
    fileref.setAttribute("href", filename);

    if(typeof fileref!="undefined"){
        document.getElementsByTagName("head")[0].appendChild(fileref)
    }
}

function loadInstagramFeed(jQuery, sk_instagram_feed){

    var embed_id=getDsmEmbedId(sk_instagram_feed);
    var json_url=app_url + "embed/instagram-hashtag-feed/widget_feed_json.php?embed_id=" + embed_id;

    // settings
    var show_profile_picture=sk_instagram_feed.find('.show_profile_picture').text();
    var show_profile_username=sk_instagram_feed.find('.show_profile_username').text();
    var show_profile_follow_button=sk_instagram_feed.find('.show_profile_follow_button').text();
    var show_profile_posts_count=sk_instagram_feed.find('.show_profile_posts_count').text();
    var show_profile_follower_count=sk_instagram_feed.find('.show_profile_follower_count').text();
    var show_profile_following_count=sk_instagram_feed.find('.show_profile_following_count').text();
    var show_profile_name=sk_instagram_feed.find('.show_profile_name').text();
    var show_profile_description=sk_instagram_feed.find('.show_profile_description').text();
    var show_profile_website=sk_instagram_feed.find('.show_profile_website').text();

    var show_load_more_button=sk_instagram_feed.find('.show_load_more_button').text();
    var show_bottom_follow_button=sk_instagram_feed.find('.show_bottom_follow_button').text();

    // text settings
    var posts_text=sk_instagram_feed.find('.posts_text').text();
    var followers_text=sk_instagram_feed.find('.followers_text').text();
    var following_text=sk_instagram_feed.find('.following_text').text();
    var follow_text=sk_instagram_feed.find('.follow_text').text();
    var load_more_posts_text=sk_instagram_feed.find('.load_more_posts_text').text();
    var view_on_instagram_text=sk_instagram_feed.find('.view_on_instagram_text').text();
    var show_post_hover=sk_instagram_feed.find('.show_post_hover').text();
    var instagram_tag=sk_instagram_feed.find('.instagram_tag').text();
    var hashtag_text=sk_instagram_feed.find('.hashtag_text').text();
    var post_count=sk_instagram_feed.find('.post_count').text();

    // get events
    jQuery.getJSON(json_url, function(data){

        if(data.message=='load failed'){

            var sk_error_message="";
            sk_error_message+="<ul class='sk_error_message'>";
                sk_error_message+="<li>Unable to load Instagram hashtag feed.</li>";
                sk_error_message+="<li>Make sure a post with <a href='https://www.instagram.com/explore/tags/" + instagram_tag + "/' target='_blank'>#" + instagram_tag + "</a> exists.</li>";
                sk_error_message+="<li>Make sure a post with <a href='https://www.instagram.com/explore/tags/" + instagram_tag + "/' target='_blank'>#" + instagram_tag + "</a> is public.</li>";
                sk_error_message+="<li>If you need help, <a href='https://www.sociablekit.com/support' target='_blank'>contact support here</a>.</li>";
            sk_error_message+="</ul>";

            sk_instagram_feed.find(".first_loading_animation").hide();
            sk_instagram_feed.append(sk_error_message);

        }else{

            var post_items="";

            if(sk_instagram_feed.find('.show_hashtag_text').text()==1){
                post_items+="<div class='sk-ig-profile-usename'>";
                    post_items+=hashtag_text;
                post_items+="</div>";
            }

            post_items+="<div class='sk-ig-all-posts'>";
            var item_counter=1;
            jQuery.each(data.posts, function(key, val){

                val['view_on_instagram_text']=view_on_instagram_text;
                val['show_post_hover']=show_post_hover;
                val['display_none']=item_counter>post_count ? 'display-none' : '';

                post_items+=getFeedItem(val, sk_instagram_feed);

                item_counter++;
            });
            post_items+="</div>";

            if(show_load_more_button==1 && (data.next_page!="" || item_counter>post_count)){
                post_items+="<div class='sk-ig-bottom-btn-container'>";
                    post_items+="<button type='button' class='sk-ig-load-more-posts'>" + load_more_posts_text + "</button>";
                post_items+="</div>";
            }

            post_items+="<div class='sk-ig-next-page display-none'>" + data.next_page + "</div>";
            sk_instagram_feed.append(post_items);
            applyCustomUi(jQuery, sk_instagram_feed);
        }
    });

}

function getFeedItem(val, sk_instagram_feed){

    var post_items="";
    post_items+="<div class='sk-ww-instagram-hashtag-feed-item " + val.display_none + "'>";

        // show on load
        if(val.show_post_hover==1){
            post_items+="<div class='sk-ig-post-hover display-none'>";

                if(val.multi_hashtag==false){
                    post_items+="<span class='m-r-15px'>";
                        post_items+="<i class='fa fa-heart' aria-hidden='true'></i> " + val.likes_count;
                    post_items+="</span>";
                    post_items+="<span>";
                        post_items+="<i class='fa fa-comment' aria-hidden='true'></i> " + val.comments_count;
                    post_items+="</span>";
                }

            post_items+="</div>";
        }

        if(val.is_video==true){
            post_items+="<div class='sk-play-btn'><i class='fa fa-play-circle' aria-hidden='true'></i></div>";
        }

        // post_items+="<img src='" + val.thumbnail_src + "' class='sk-ig-post-img' />";
        post_items+="<div style='background-image: url(" + val.thumbnail_src + "); background-size:cover; background-position:center center;' class='sk-ig-post-img'></div>";

        // show in pop up
        post_items+="<div class='white-popup mfp-hide sk-pop-ig-post'>";

            post_items+="<div class='sk-media-post-container'>";

                // show in pop up
                if(val.is_video==true){

                    post_items+="<div class='sk_loading_video' data-code='" + val.code + "'>";
                        post_items+="<i class='fa fa-spinner fa-pulse' aria-hidden='true'></i>";
                    post_items+="</div>";

                }else{
                    // use data.post.display_src if you need large image
                    post_items+="<img src='" + val.thumbnail_src + "' class='ig_media' />";
                }

            post_items+="</div>";

            post_items+="<div class='post_details' style=\"font-family:" + getDsmSetting(sk_instagram_feed, "font_family") + ";\">";

                if(val.multi_hashtag==false){
                    post_items+="<span class='sk-ig-feed-m-r-15px'>";
                        post_items+="<i class='fa fa-heart' aria-hidden='true'></i> " + val.likes_count;
                    post_items+="</span>";
                    post_items+="<span class='sk-ig-feed-m-r-15px'>";
                        post_items+="<i class='fa fa-comment' aria-hidden='true'></i> " + val.comments_count;
                    post_items+="</span>";
                    post_items+="<span class='sk-ig-pop-up-icon'>";
                        post_items+="<a href='" + val.view_on_ig_link + "' target='_blank'>";
                            post_items+="<i class='fa fa-instagram' aria-hidden='true'></i> " + val.view_on_instagram_text;
                        post_items+="</a>";
                    post_items+="</span>";
                }else{
                    post_items+="<span class='sk-ig-feed-m-r-15px'>";
                        post_items+="<i class='fa fa-instagram' aria-hidden='true'></i> ";
                        post_items+="<a href='https://www.instagram.com/" + val.post_by + "' target='_blank'>";
                            post_items+=val.post_by;
                        post_items+="</a>";
                    post_items+="</span>";
                    post_items+="<span class='sk-ig-pop-up-icon'>";
                        post_items+="<i class='fa fa-time' aria-hidden='true'></i> " + val.post_date;
                    post_items+="</span>";
                }

                if(val.caption!=null){
                    post_items+="<div class='sk-ig-feed-m-t-10px sk-ig-pic-text'>";

                        if(val.post_by!=""){
                            post_items+="<a href='https://www.instagram.com/" + val.post_by + "' target='_blank'>";
                                post_items+="<strong>" + val.post_by + "</strong>";
                            post_items+="</a> ";
                        }

                        post_items+=val.caption;
                    post_items+="</div>";
                }
            post_items+="</div>";
        post_items+="</div>";

    post_items+="</div>"; // END sk-ww-instagram-hashtag-feed-item

    return post_items;
}

function showPopUp(jQuery, content_src, clicked_element){

    // pop up options
    var sk_instagram_feed=jQuery(this).closest('.sk-ww-instagram-hashtag-feed')
    var show_pop_up_on_middle=jQuery(clicked_element).closest('.sk-ww-instagram-hashtag-feed').find('.show_pop_up_on_middle').text();
    var clicked_element_pos=jQuery(clicked_element).offset().top;
    var relative_pos=clicked_element_pos - jQuery(window).scrollTop() - 200;

    // open pop up
    jQuery.magnificPopup.open({
        items: { src: content_src },
        'type' : 'inline',
        callbacks: {
            open: function() {

                if(show_pop_up_on_middle==0){
                    jQuery('.mfp-container').css({ 'top' : relative_pos + 'px' });
                }

                // show prev / next nav
                var post_html="";
                if(clicked_element.prev().length>0){
                    post_html+="<button type='button' class='prev-sk-post'>";
                        post_html+="<i class='fa fa-chevron-left sk_prt_4px' aria-hidden='true'></i>";
                    post_html+="</button>";
                }

                if(clicked_element.next().length>0){
                    post_html+="<button type='button' class='next-sk-post'>";
                        post_html+="<i class='fa fa-chevron-right sk_plt_4px' aria-hidden='true'></i>";
                    post_html+="</button>";
                }

                jQuery('.sk-media-post-container').prepend(post_html);

                console.log('font family: ' + getDsmSetting(sk_instagram_feed, "font_family"));

                // make link clickable
                jQuery('.mfp-content .sk-ig-pic-text').css({
                    'font-family' : "Verdana, Geneva, sans-serif"
                });

                // read one post
                var code=content_src.find('.sk_loading_video').attr('data-code');

                if(code!=undefined){
                    var json_url=app_url + "embed/instagram-hashtag-feed/widget_read_one_json.php?code=" + code;

                    jQuery.getJSON(json_url, function(data){
                    	var video_tag="<video autoplay controls class='sk_video_tag'>";
                    		video_tag+="<source src=" + data.post.video_url + " type='video/mp4'>";
                    		video_tag+="Your browser does not support the video tag.";
                    	video_tag+="</video>";

                    	content_src.find('.sk_loading_video').html(video_tag);
                        content_src.find('.sk_loading_video').removeClass('sk_loading_video');
                    });

                    /*
                    if(jQuery('.mfp-content .sk-media-post-container video').get(0)!==undefined){
                        jQuery('.mfp-content .sk-media-post-container video').get(0).play();
                    }
                    */
                }

            },
            close: function() {
                if(show_pop_up_on_middle==0){
                    jQuery('.mfp-container').css({ 'top' : '0px' });
                }

                // remove prev / next buttons
                jQuery(".prev-sk-post, .next-sk-post").remove();

            }
        }
    });

    applyCustomUi(jQuery, sk_instagram_feed);
}

// make widget responsive
function makeResponsive(jQuery, sk_instagram_feed){

    // change height to normal
    sk_instagram_feed.css({'height' : 'auto'});

    var sk_instagram_feed_width = sk_instagram_feed.width();

	/* smartphones, iPhone, portrait 480x320 phones */
	if(sk_instagram_feed_width<=320){

	}

	/* portrait e-readers (Nook/Kindle), smaller tablets @ 600 or @ 640 wide. */
	else if(sk_instagram_feed_width<=481){

	}

	/* portrait tablets, portrait iPad, landscape e-readers, landscape 800x480 or 854x480 phones */
	else if(sk_instagram_feed_width<=641){

	}

	/* tablet, landscape iPad, lo-res laptops ands desktops */
	else if(sk_instagram_feed_width<=961){

	}

	/* big landscape tablets, laptops, and desktops */
	else if(sk_instagram_feed_width<=1025){

	}

	/* hi-res laptops and desktops */
	else if(sk_instagram_feed_width<=1281){

	}

    /* wider screen */
    else if(sk_instagram_feed_width>1281){

	}

}

function applyCustomUi(jQuery, sk_instagram_feed){

    // hide 'loading animation' image
    sk_instagram_feed.find(".loading-img").hide();

    // container width
    sk_instagram_feed.css({ 'width' : '100%' });
    var sk_instagram_feed_width=sk_instagram_feed.innerWidth();

    // change height to normal
    sk_instagram_feed.css({'height' : 'auto'});

    var column_count=sk_instagram_feed.find('.column_count').text();
	if(
        /* smartphones, iPhone, portrait 480x320 phones */
        sk_instagram_feed_width<=320 ||

    	/* portrait e-readers (Nook/Kindle), smaller tablets @ 600 or @ 640 wide. */
    	sk_instagram_feed_width<=481 ||

    	/* portrait tablets, portrait iPad, landscape e-readers, landscape 800x480 or 854x480 phones */
    	sk_instagram_feed_width<=641
    ){
        if(getDsmSetting(sk_instagram_feed, "column_count")==1){
            column_count=1;
        }else{
            column_count=2;
        }
	}

    // size settings
    var border_size=0;
    var background_color="#555555";
    var space_between_images=sk_instagram_feed.find('.space_between_images').text(); // get total space (5)
    var margin_between_images=parseFloat(space_between_images).toFixed(2) / 2; // get the half (2.5)

    var total_space_between_images=parseFloat(space_between_images).toFixed(2)*(parseFloat(column_count)); // (15)

    // ((1887 - 15) / 3) = 624
    var pic_width=(parseFloat(sk_instagram_feed_width).toFixed(2) - parseFloat(total_space_between_images).toFixed(2))
                    / parseFloat(column_count).toFixed(2);

    var sk_ig_all_posts_minus_spaces=parseFloat(sk_instagram_feed_width).toFixed(2)-parseFloat(total_space_between_images).toFixed(2);
    var bottom_button_container_width=parseFloat(sk_instagram_feed_width).toFixed(2)-(parseFloat(space_between_images).toFixed(2)*2);
    var bottom_button_width=parseFloat(sk_instagram_feed_width).toFixed(2) / parseFloat(2).toFixed(2);

    // font & color settings
    var font_family=sk_instagram_feed.find('.font_family').text();
    var details_bg_color=sk_instagram_feed.find('.details_bg_color').text();
    var details_font_color=sk_instagram_feed.find('.details_font_color').text();
    var details_link_color=sk_instagram_feed.find('.details_link_color').text();
    var details_link_hover_color=sk_instagram_feed.find('.details_link_hover_color').text();
    var button_bg_color=sk_instagram_feed.find('.button_bg_color').text();
    var button_text_color=sk_instagram_feed.find('.button_text_color').text();
    var button_hover_bg_color=sk_instagram_feed.find('.button_hover_bg_color').text();
    var button_hover_text_color=sk_instagram_feed.find('.button_hover_text_color').text();
    var title_line_height=sk_instagram_feed.find('.title_line_height').text();

    sk_instagram_feed.find('.sk-ww-instagram-hashtag-feed-item').css({
        'width' : pic_width + 'px',
        'height' : pic_width + 'px',
        'margin' : margin_between_images + 'px',
        'background-color' : background_color,
        'padding' : border_size
    });

    // hashtag title
    sk_instagram_feed.find('.sk-ig-profile-usename').css({
        'color' : details_font_color,
        'line-height' : title_line_height + 'px'
    });

    // hover
    var hover_width=sk_instagram_feed.find('.sk-ww-instagram-hashtag-feed-item').width();
    sk_instagram_feed.find('.sk-ig-post-hover').css({
        'width' : hover_width + 'px',
        'height' : hover_width + 'px',
        'margin' : 0,
        'padding' : 0,
        'line-height' : hover_width + 'px'
    });

    // resize the actual image as well
    sk_instagram_feed.find('.sk-ww-instagram-hashtag-feed-item .sk-ig-post-img').css({
        'width' : pic_width + 'px',
        'height' : pic_width + 'px'
    });

    // apply font family
    sk_instagram_feed.css({
        'font-family' : sk_instagram_feed.find('.font_family').text(),
        'background-color' : details_bg_color,
        'width' : sk_instagram_feed_width + 'px'
    });

    // pop up settings
    jQuery('.sk-pop-ig-post, .sk-ig-pic-text').css({
        'font-family' : sk_instagram_feed.find('.font_family').text()
    });

    // details
    sk_instagram_feed.find('.instagram-user-root-container').css({
        'color' : details_font_color
    });

    // details link
    sk_instagram_feed.find('.instagram-user-root-container a').css({
        'color' : details_link_color
    });

    $(".instagram-user-root-container a").mouseover(function() {
        $(this).css({'color' : details_link_hover_color});
    }).mouseout(function() {
        $(this).css({'color' : details_link_color});
    });

    // buttons
    var margin_bottom_sk_ig_load_more_posts=space_between_images;
    if(margin_bottom_sk_ig_load_more_posts==0){
        margin_bottom_sk_ig_load_more_posts=5;
    }
    sk_instagram_feed.find(".sk-ig-load-more-posts").css({
        'margin-bottom' : margin_bottom_sk_ig_load_more_posts + 'px'
    });

    sk_instagram_feed.find(".instagram-user-container, .sk-ig-load-more-posts, .sk-ig-bottom-follow-btn")
        .css({
            'background-color' : button_bg_color,
            'border-color' : button_bg_color,
            'color' : button_text_color
        });

    sk_instagram_feed.find(".instagram-user-container, .sk-ig-load-more-posts, .sk-ig-bottom-follow-btn")
        .mouseover(function(){
            $(this).css({
                'background-color' : button_hover_bg_color,
                'border-color' : button_hover_bg_color,
                'color' : button_hover_text_color
            });
        }).mouseout(function(){
            $(this).css({
                'background-color' : button_bg_color,
                'border-color' : button_bg_color,
                'color' : button_text_color
            });
        });

    // bottom buttons container
    var padding_sk_ig_bottom_btn_container=margin_between_images;
    if(padding_sk_ig_bottom_btn_container==0){
        padding_sk_ig_bottom_btn_container=5;
    }
    sk_instagram_feed.find(".sk-ig-bottom-btn-container").css({
        'padding' : padding_sk_ig_bottom_btn_container + 'px'
    });

    jQuery(".sk-media-post-container, .mfp-close, .prev-sk-post, .next-sk-post")
        .mouseover(function(){
            jQuery(".mfp-close, .prev-sk-post, .next-sk-post").attr("style", "opacity: 0.8 !important;");
        }).mouseout(function(){
            jQuery(".mfp-close, .prev-sk-post, .next-sk-post").attr("style", "opacity: 0.3 !important;");
        });

}

// our main function
function main(){

    // manipulate page using jQuery
    jQuery(document).ready(function($) {

        jQuery('.sk-ww-instagram-hashtag-feed').each(function(){

            // know what to show
            var sk_instagram_feed=jQuery(this);
            var embed_id=getDsmEmbedId(sk_instagram_feed);



            // get current url
            var current_url=encodeURIComponent(window.location.href);

            // get settings
            var json_url=app_url + "embed/instagram-hashtag-feed/widget_settings_json.php?embed_id=" + embed_id + "&current_url=" + current_url;

            jQuery.getJSON(json_url, function(data){

                if(data.show_feed==false){

                    sk_instagram_feed.find('.loading-img').hide();
                    sk_instagram_feed.prepend(data.message);
                }

                else{

                    // change height to be more than current window
                    if(data.show_content_space==1){
                        var new_sk_instagram_feed_height=jQuery(window).height() + 100;
                        sk_instagram_feed.height(new_sk_instagram_feed_height);
                    }

                    // save some settings in html
                    var settings_html="";

                    // settings for easy access
                    settings_html+="<div style='display:none;' class='display-none sk-ig-settings'>";
                        jQuery.each(data, function(key, value){ settings_html+="<div class='" + key + "'>" + value + "</div>"; });
                    settings_html+="</div>";

                    if(sk_instagram_feed.find('.sk-ig-settings').length){ }
                    else{ sk_instagram_feed.prepend(settings_html); }

                    // empty settings
                    settings_html="";
                    loadInstagramFeed(jQuery, sk_instagram_feed);

                }
            });
        });

        // resize elements in real time
        jQuery(window).resize(function(){
            jQuery('.sk-ww-instagram-hashtag-feed').each(function(){
                var sk_instagram_feed=jQuery(this);
                applyCustomUi(jQuery, sk_instagram_feed);
            });
        });

        jQuery(document).on('click', '.prev-sk-post', function(){
            // clicked 'next' button
            var clicked_element=jQuery(this);

            // next post item
            var new_clicked_element=jQuery('.sk_selected_ig_post').prev('.sk-ww-instagram-hashtag-feed-item');

            // content of pop up
            var content_src=new_clicked_element.find('.sk-pop-ig-post');

            // activate new selected post
            jQuery('.sk_selected_ig_post').removeClass('sk_selected_ig_post');
            new_clicked_element.addClass('sk_selected_ig_post');

            // close current pop up
            hidePopUp();

            // show new pop up
            showPopUp(jQuery, content_src, new_clicked_element);
        });

        jQuery(document).on('click', '.next-sk-post', function(){

            // clicked 'next' button
            var clicked_element=jQuery(this);

            // next post item
            var new_clicked_element=jQuery('.sk_selected_ig_post').next('.sk-ww-instagram-hashtag-feed-item');

            // content of pop up
            var content_src=new_clicked_element.find('.sk-pop-ig-post');

            // activate new selected post
            jQuery('.sk_selected_ig_post').removeClass('sk_selected_ig_post');
            new_clicked_element.addClass('sk_selected_ig_post');

            // close current pop up
            hidePopUp();

            // show new pop up
            showPopUp(jQuery, content_src, new_clicked_element);
        });

        jQuery(document).on('click', '.sk-ww-instagram-hashtag-feed .sk-ww-instagram-hashtag-feed-item', function(){

            // remove all selected post
            jQuery('.sk_selected_ig_post').removeClass('sk_selected_ig_post');

            var clicked_element=jQuery(this);
            var content_src=clicked_element.find('.sk-pop-ig-post');

            // activate selected post
            clicked_element.addClass('sk_selected_ig_post');

            showPopUp(jQuery, content_src, clicked_element);
        });

        jQuery(document).on('click', '.sk-ww-instagram-hashtag-feed .sk-ig-load-more-posts', function(){

            var current_btn=jQuery(this);
            var current_btn_text=current_btn.text();
            var sk_instagram_feed=jQuery(this).closest('.sk-ww-instagram-hashtag-feed')
            var embed_id=getDsmEmbedId(sk_instagram_feed);
            var next_page=sk_instagram_feed.find('.sk-ig-next-page').text();
            var json_url=app_url + "embed/instagram-hashtag-feed/widget_feed_json.php?embed_id="
                        + embed_id + "&next_page=" + encodeURIComponent(next_page);
            var end_of_posts_text=sk_instagram_feed.find('.end_of_posts_text').text();
            var view_on_instagram_text=sk_instagram_feed.find('.view_on_instagram_text').text();
            var show_post_hover=sk_instagram_feed.find('.show_post_hover').text();

            // show loading animation
            jQuery(this).html("<i class='fa fa-spinner fa-pulse' aria-hidden='true'></i>");

            if(next_page==""){
                sk_instagram_feed.find(".sk-ww-instagram-hashtag-feed-item").show();
                sk_instagram_feed.find('.sk-ig-load-more-posts').hide();
            }

            else{
                // get events
                jQuery.getJSON(json_url, function(data){

                    var post_items="";

                    jQuery.each(data.posts, function(key, val){

                        val['view_on_instagram_text']=view_on_instagram_text;
                        val['show_post_hover']=show_post_hover;
                        val['display_none']='';

                        post_items+=getFeedItem(val, sk_instagram_feed);

                        sk_instagram_feed.find('.sk-ww-instagram-hashtag-feed-item').show();
                    });

                    // add posts to current posts
                    sk_instagram_feed.find('.sk-ig-all-posts').append(post_items);

                    // go back to previous button text
                    current_btn.html(current_btn_text);

                    // change next page value
                    sk_instagram_feed.find('.sk-ig-next-page').text(data.next_page);

                    // if no next page, disable load more button
                    if(data.next_page==""){
                        sk_instagram_feed.find('.sk-ig-load-more-posts').hide();
                    }

                    // apply customizations and sizings
                    applyCustomUi(jQuery, sk_instagram_feed);

                });
            }

        });

        jQuery(document).on('click', '.sk-ww-instagram-hashtag-feed .sk-watermark', function(){
            jQuery('.sk-ww-instagram-hashtag-feed .sk-message').slideToggle();
        });


    }); // end document ready
}

function hidePopUp(){
    jQuery.magnificPopup.close();
}

}(window, document)); // We call our anonymous function immediately