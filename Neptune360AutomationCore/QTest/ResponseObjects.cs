using System;
using System.Collections.Generic;

namespace Neptune360UIAutomation
{

    public class Link
    {
        public string rel { get; set; }
        public string href { get; set; }
    }

    public class Property
    {
        public int field_id { get; set; }
        public object field_value { get; set; }
    }

    public class GetProjectId
    {
        public List<Link> links { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int status_id { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public bool sample { get; set; }
        public List<object> defect_tracking_systems { get; set; }
        public int x_explorer_access_level { get; set; }
        public string date_format { get; set; }
        public bool automation { get; set; }
    }

    public class GetReleaseId
    {
        public List<Link> links { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public string pid { get; set; }
        public List<Property> properties { get; set; }
        public string web_url { get; set; }
        public string description { get; set; }
        public string note { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
    }

    public class GetTestCycleId
    {
        public List<Link> links { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public string pid { get; set; }
        public string web_url { get; set; }
        public int target_release_id { get; set; }
        public List<object> invalid_name__test_cycles { get; set; }
    }

    public class GetTestSuites
    {
        public List<Link> links { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public string pid { get; set; }
        public List<Property> properties { get; set; }
        public string web_url { get; set; }
    }

    public class GetTestRunsItems
    {
        public List<GetTestRuns> items { get; set; }
        public int page { get; set; }
        public int pagesize { get; set; }
        public int total { get; set; }

    }

    public class GetTestRuns
    {
        public List<Link> links { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string pid { get; set; }
        public List<Property> properties { get; set; }
        public int test_case_version_id { get; set; }
        public int creator_id { get; set; }
    }

    public class GetTestCaseNameById
    {
        public List<Link> links { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string pid { get; set; }
        public List<Property> properties { get; set; }
        public int test_case_version_id { get; set; }
        public int creator_id { get; set; }
    }

    public class GetTestSteps
    {
        public List<Link> links { get; set; }
        public int id { get; set; }
        public string description { get; set; }
        public string expected { get; set; }
        public int order { get; set; }
        public List<object> attachments { get; set; }
        public int group { get; set; }
        public string plain_value_text { get; set; }
    }

    public class Author
    {
        public int id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
    public class GetAttachments
    {
        public List<Link> links { get; set; }
        public string name { get; set; }
        public string content_type { get; set; }
        public int id { get; set; }
        public string web_url { get; set; }
        public DateTime created_date { get; set; }
        public Author author { get; set; }
        public int artifact_id { get; set; }
    }
}
