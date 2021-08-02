<Query Kind="Statements">
  <NuGetReference>Rock.Core.Newtonsoft</NuGetReference>
</Query>

using Newtonsoft.Json.Linq;

var json_config = @"
                    {'network':
                           [
                            {'hostname':'comp01', 'ip':'192.168.5.9', 'groups':['accountancy','financial']},
                            {'hostname':'comp02', 'ip':'192.168.5.10', 'groups': ['administration']},
                           ]
                    }";
var network = JObject.Parse(json_config)["network"];
var results = from computer in network select 
				from roles in computer["groups"] select 
				new {hostname = computer["hostname"], ip = computer["ip"], roles = roles};
var tabular = results.SelectMany(item => item);
tabular.Dump();