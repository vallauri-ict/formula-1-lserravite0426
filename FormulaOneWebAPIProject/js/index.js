"use strict";

let app;

$(function () {
    app = new Vue({
        el: "#app",
        data: {
            data: [],
            rows: [],
            dataRequired: '',
            disableButtons: false,
            searchID: '',
            notFound: false
        },
        methods: {
            request: function (uri) {
                this.disableButtons = true;
                this.data = [];
                this.rows = [];
                this.searchID = '';
                this.notFound = false;
                this.dataRequired = uri;
                $.getJSON('/api/' + uri)
                    .done(data => {
                        console.log(data);
                        this.data = data;
                        createRow();
                    })
                    .fail((jqxhr, textStatus, error) => {
                        console.log(jqxhr, textStatus, error);
                    })
                    .always(() => this.disableButtons = false);
            },
            search: function () {
                this.notFound = false;
                if (this.searchID == '')
                    createRow();
                else {
                    let item = this.data.find(i => i.id == this.searchID);
                    if (item == undefined)
                        this.notFound = true;
                    else
                        this.rows = [[item]];
                }
            }
        }
    });
});

function createRow() {
    for (let i = 0; i < app.data.length; i += 3) {
        app.rows[i] = app.data.slice(i, i + 3);
    }
}