const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    let Lab = sequelize.define("Lab", {
        name: {
            type: Sequelize.TEXT,
            allowNull: false
        },
        capacity: {
            type: Sequelize.INTEGER,
            allowNull: false
        },
        status: {
            type: Sequelize.TEXT,
            allowNull: false
        }
    }, {
        timestamps: false
    });

    return Lab;
};