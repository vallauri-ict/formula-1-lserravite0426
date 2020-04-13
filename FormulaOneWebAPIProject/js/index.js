"use strict";

$(function () {
    let app = new Vue({
        el: "#app",
        data: {
            data: [],
            rows: [],
            dataRequired: '',
            disableButtons: false
        },
        methods: {
            request: function (uri) {
                this.disableButtons = true;
                this.data = [];
                this.rows = [];
                this.dataRequired = uri;
                $.getJSON('/api/' + uri)
                    .done(data => {
                        console.log(data);
                        this.data = data;
                        for (let i = 0; i < this.data.length; i += 3) {
                            this.rows[i] = this.data.slice(i, i + 3);
                        }
                    })
                    .fail((jqxhr, textStatus, error) => {
                        console.log(jqxhr, textStatus, error);
                    })
                    .always(() => this.disableButtons = false);
            }
        }
    });

    
});