/* with dynamic, type is not known until runtime */

var json = @"[
  { 'id': 'A', 'work': { 'name': 'ACME 2', 'location': 'NY' } },
  { 'id': 'B', 'work': { 'name': 'Box Co', 'location': 'SF' } },
  { 'id': 'C', 'work': { 'name': 'DotCom', 'location': 'NY' } }
]";

var users = JsonConvert.DeserializeObject&lt;List&lt;dynamic>>(json);

var name = users.First().work.name;
// ACME 2

var fromNY = users
              .Where(e => e.work.location == "NY")
              .Select(e => e.id);
// [A, C]