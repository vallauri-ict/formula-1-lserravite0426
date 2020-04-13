Vue.component('driver-card', {
    template: `
        <div class="card" style="height: 100%">
            <div class="card-image">
                <figure class="image is-1by1">
                    <img :src="driver.img">
                </figure>
            </div>
            <div class="card-content">
                <div class="media">
                    <div class="media-left">
                        <figure class="image is-48x48">
                            <img :src="driver.img">
                        </figure>
                    </div>
                    <div class="media-content">
                        <p class="title is-4">{{ driver.firstname }} {{ driver.lastname }}</p>
                        <p class="subtitle is-6">{{ new Date(driver.dob).toUTCString() }} - {{ driver.placeOfBirth }} ({{ driver.country.name }})</p>
                    </div>
                </div>

                <div class="content">
                    {{ driver.description }}
                </div>
            </div>
        </div>
    `,
    props: ['driver']
});
Vue.component('team-card', {
    template: `
        <div class="card" style="height: 100%">
            <div class="card-image">
                <figure class="image is-5by4">
                    <img :src="team.img">
                </figure>
            </div>
            <div class="card-content">
                <div class="media">
                    <div class="media-left">
                        <figure class="image is-48x48">
                            <img :src="team.img">
                        </figure>
                    </div>
                    <div class="media-content">
                        <p class="title is-4">{{ team.fullTeamName }}</p>
                        <p class="subtitle is-6">{{ team.powerUnit }}</p>
                    </div>
                </div>
                <div class="content">
                    <p><strong>Country:</strong> {{ team.country.name }}</p>
                    <p><strong>Technical chief:</strong> {{ team.technicalChief }}</p>
                    <p><strong>Chassis:</strong> {{ team.chassis }}</p>
                    <p><strong>First driver:</strong> {{ team.firstDriver.firstname }} {{ team.firstDriver.lastname }}</p>
                    <p><strong>Second driver:</strong> {{ team.secondDriver.firstname }} {{ team.secondDriver.lastname }}</p>
                </div>
            </div>
        </div>
    `,
    props: ['team']
});
Vue.component('circuit-card', {
    template: `
        <div class="card" style="height: 100%">
            <div class="card-image">
                <figure class="image is-2by1">
                    <img :src="circuit.img">
                </figure>
            </div>
            <div class="card-content">
                <div class="media">
                    <div class="media-left">
                        <figure class="image is-48x48">
                            <img :src="circuit.img">
                        </figure>
                    </div>
                    <div class="media-content">
                        <p class="title is-4">{{ circuit.name }}</p>
                        <p class="subtitle is-6">{{ circuit.country.name }}</p>
                    </div>
                </div>

                <div class="content">
                    <p><strong>Length:</strong> {{ circuit.length }} m</p>
                    <p><strong>Laps:</strong> {{ circuit.laps }}</p>
                    <p><strong>Record lap:</strong> {{ circuit.recordLap }}</p>
                </div>
            </div>
        </div>
    `,
    props: ['circuit']
});