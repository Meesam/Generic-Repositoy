namespace Data.Entity
{
    public class Users
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}
<script type="text/javascript">
        var testData = "";
        $.ajax({
            url: "/OrgChart/GetOrgChat",
            datatype: "json",
            success: function (jsonresponce) {
                testData = jsonresponce;
            }
        }).done(function(){
            org_chart = $('#orgChart').orgChart({
                data: testData,
                showControls: false,
                allowEdit: false,
                onClickNode: function (node) {
                    $(".node").popover({
                        title: "Software Engineer",
                        content: "Since then, software engineering undergraduate degrees have been established at many universities. A standard international curriculum for undergraduate software engineering degrees was recently[when?] defined by the CCSE. As of 2004, in the U.S.",
                        placement: "right"
                    });
                }
            });
        });
    </script>   
