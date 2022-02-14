

add-migration AppUser -Context UserDbContext -OutputDir  "migrations/appuser"
update-database -Context UserDbContext


add-migration AppUser -Context AppDbContext -OutputDir  "migrations/projectdb"
update-database -Context AppDbContext


add-migration ProjectSprint -Context AppDbContext -OutputDir  "migrations/projectdb

