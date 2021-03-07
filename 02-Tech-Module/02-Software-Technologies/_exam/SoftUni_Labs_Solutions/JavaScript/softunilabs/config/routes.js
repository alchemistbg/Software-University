const labController = require('../controllers/lab');

module.exports = (app) => {
	app.get('/', labController.index);

	app.get('/create/', labController.createGet);
	app.post('/create/', labController.createPost);

	app.get('/edit/:id', labController.editGet);
	app.post('/edit/:id', labController.editPost);

	app.get('/delete/:id', labController.deleteGet);
	app.post('/delete/:id', labController.deletePost);
};