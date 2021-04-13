create database lojavirtual;
use lojavirtual;

create table produto(
id int auto_increment not null primary key,
nome varchar(40) not null,
descricao varchar(80) not null,
fornecedorId int not null,
categoriaId int not null,
quantidadeEstoque int unsigned not null,
foto varchar(30) not null,
foreign key(fornecedorId) references fornecedor(id) on update cascade on delete cascade,
foreign key(categoriaId) references categoria(id) on update cascade on delete cascade
)engine = InnoDB;


create table clientes(
id int auto_increment not null primary key,
nome varchar(80) not null,
cpf char(14) not null,
endereco varchar(150) not null,
telefone char(14) not null,
email varchar(100) not null,
senha varchar(20) not null
)engine=InnoDB;

create table categoria(
id int auto_increment not null primary key,
nome varchar(50) not null,
descricao varchar(50) not null
)engine=innodb; 

create table fornecedor(
id int auto_increment not null primary key,
nome varchar(80) not null,
cnpj char(14) not null,
email varchar(100) not null,
senha varchar(20) not null,
telefone char(14) not null,
nomeRepresentante varchar(80) not null,
telefoneRepresentante char(14) not null
)engine=innodb;





