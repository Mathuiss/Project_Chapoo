select b.id, g.naam, b.tafel, b.aantekening 
from bestelling as b 
join inhoudbestelling as inhoud on b.id = inhoud.id 
join gerecht as g on inhoud.id = g.id where categorie = 1

select b.id, g.naam, b.tafel, b.aantekening from bestelling as b join inhoudbestelling as inhoud on b.id = inhoud.id join gerecht as g on inhoud.id = g.id

SELECT b.id, g.naam, b.tafel, b.aantekening
  From bestelling as b,inhoudbestelling as inhoud, gerechten as g
  where b.id = inhoud.idBestelling 
  and inhoud.idGerecht = g.id