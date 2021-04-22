ALTER TABLE `person` DISABLE KEYS;
INSERT INTO `person` (`id`, `address`, `first_name`, `gender`, `last_name`) VALUES
	(1, 'São Paulo', 'Saulo', 'Male', 'Cruz'),
	(2, 'São Paulo', 'Salomao', 'Male', 'Cruz'),
	(3, 'São Paulo', 'Erika', 'Female', 'Cruz');
ALTER TABLE `person` ENABLE KEYS;